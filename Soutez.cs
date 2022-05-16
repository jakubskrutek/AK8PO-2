using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO_2
{
    /// <summary>
    /// Třída reprezentující přidanou soutěž
    /// </summary>
    public class Soutez
    {
        public string OdkazTabulka { get; set; }

        public string NazevSouteze { get; set; }

        public string OdkazLos { get; set; }

        public string[,] Losy { get; set; }

        public string[] Teamy { get; set; }

        /// <summary>
        /// Konstruktor soutěže
        /// </summary>
        /// <param name="odkaz">Webový odkaz na tabulku soutěže</param>
        public Soutez (string odkaz)
        {
            OdkazTabulka = odkaz;
            OdkazLos = odkaz.Replace("tabulka", "los-vse");
            NazevSouteze = ZiskejNazevSouteze(odkaz);
            Losy = NactiLosy(odkaz);
            Teamy = NactiTeamy(Losy);
        }

        /// <summary>
        /// Metoda pro vytvoření názvu soutěže pro její představování
        /// </summary>
        /// <param name="odkaz">Webový odkaz na soutěž</param>
        /// <returns>Název soutěže + ročník</returns>
        private string ZiskejNazevSouteze(string odkaz)
        {            
            odkaz = odkaz.Replace("tabulka", "los-vse");

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData(odkaz);                            // stáhne stránku v HTML
            string data = System.Text.Encoding.UTF8.GetString(raw);

            int index = odkaz.IndexOf("soutez-") + 7;
            string cisloSouteze = odkaz.Substring(index);
            index = data.IndexOf(cisloSouteze) + 6;                         // parsování textu dle hledaných kritérií
            string nazevSouteze = data.Substring(index, 100);
            index = nazevSouteze.IndexOf('<');
            nazevSouteze = nazevSouteze.Substring(0, index).Trim();

            index = odkaz.IndexOf("rocnik-");
            int rocnik = int.Parse(odkaz.Substring(index + 7, 4));
            nazevSouteze = nazevSouteze + " - " + rocnik.ToString() + "/" + (rocnik + 1).ToString();            // přidání ročníku soutěže

            return nazevSouteze;
        }

        /// <summary>
        /// Metoda pro parsování losu z textu z HTML stránky soutěže
        /// </summary>
        /// <param name="odkaz">Odkaz na los soutěže</param>
        /// <returns>Los soutěže</returns>
        private string[,] NactiLosy(string odkaz)
        {
            /*** Indexy: 1 - kolo, 2 - termín, 3 - domácí, 4 - hosté, 5 - výsledek ***/

            odkaz = odkaz.Replace("tabulka", "los-vse");

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData(odkaz);                            // stáhne stránku s losem soutěže v HTML
            string data = System.Text.Encoding.UTF8.GetString(raw);

            string[,] vysledky = new string[1000, 5];
            string zasobnik = "";
            string buffer = "";
            byte faze = 1;
            byte volba = 1;
            byte pomocna = 0;
            int radek = 0;
            int index = odkaz.IndexOf("soutez");
            string soutez = odkaz.Substring(index) + "\">";

            foreach (char znak in data) {                           // hlavní cyklus pro parsování textu, načítá po znaku...
                zasobnik += znak;
                if (faze == 1) {
                    if (zasobnik.Contains("Hosté")) {               // ...dokud text neobsahuje klíčové slovo
                        zasobnik = "";
                        faze = 2;
                    }
                }
                else if (faze == 2) {
                    switch (volba) {                                // začíná parsování
                        case 1:                                     // hledá se číslovka kola soutěže
                            if (zasobnik.Contains("Jméno"))         // klíčové slovo pro případné ukončení hledání (celý los načten)
                                faze = 3;
                            if ((zasobnik.Contains("1")) || (zasobnik.Contains("2")) || (zasobnik.Contains("3")) || (zasobnik.Contains("4")) || 
                                (zasobnik.Contains("5")) || (zasobnik.Contains("6")) || (zasobnik.Contains("7")) || (zasobnik.Contains("8")) || 
                                (zasobnik.Contains("9"))){
                                buffer += znak;
                                if (buffer.Length == 4) {
                                    for (int i = 0; i < buffer.Length; i++) {
                                        if ((buffer[i] == '1') || (buffer[i] == '2') || (buffer[i] == '3') || (buffer[i] == '4') ||
                                            (buffer[i] == '5') || (buffer[i] == '6') || (buffer[i] == '7') || (buffer[i] == '8') ||
                                            (buffer[i] == '9') || (buffer[i] == '0') || (buffer[i] == '.'))
                                            vysledky[radek, 0] += buffer[i];
                                    }
                                }
                                if (buffer.Length == 4) {
                                    buffer = "";
                                    zasobnik = "";
                                    volba = 2;
                                }
                            }
                        break;
                        case 2:                                 // hledá se termín soutěže
                            if ((zasobnik.Contains("Po")) || (zasobnik.Contains("Út")) || (zasobnik.Contains("St")) || 
                                (zasobnik.Contains("Čt")) || (zasobnik.Contains("Pá")) || (zasobnik.Contains("So")) || (zasobnik.Contains("Ne"))) {
                                pomocna++;
                                if (pomocna == 18) {
                                    vysledky[radek, 1] = zasobnik.Substring(zasobnik.Length - 19);
                                    pomocna = 0;
                                    volba = 3;
                                    zasobnik = "";
                                }
                            }
                        break;
                        case 3:                                     // hledá se domácí tým
                            if (zasobnik.Contains(soutez)) {
                                buffer += znak;
                                if (buffer.Contains("<")) {
                                    for (int i = 0; i < buffer.Length; i++) {
                                        if ((buffer[i] != '\\') && (buffer[i] != '<') && (buffer[i] != '>'))
                                            vysledky[radek, 2] += buffer[i];
                                    }
                                    buffer = "";
                                    volba = 4;
                                    zasobnik = "";
                                }
                            }
                        break;
                        case 4:                                     // hledá se hostující tým
                            if (zasobnik.Contains(soutez)) {
                                buffer += znak;
                                if (buffer.Contains("<")) {
                                    for (int i = 0; i < buffer.Length; i++) {
                                        if ((buffer[i] != '\\') && (buffer[i] != '<') && (buffer[i] != '>'))
                                            vysledky[radek, 3] += buffer[i];
                                    }
                                    buffer = "";
                                    volba = 5;
                                    zasobnik = "";
                                }
                            }
                        break;
                        case 5:                                     // hledá se výsledek
                            if (zasobnik.Contains("Výsledek:")) {
                                buffer += znak;
                                if (buffer.Contains("<")) {
                                    vysledky[radek, 4] = buffer.Substring(1, buffer.Length - 2).Trim();
                                    zasobnik = "";
                                }
                            }
                            if (zasobnik.Contains("</a>")) {
                                buffer = "";
                                zasobnik = "";
                                volba = 1;
                                radek++;
                            }
                        break;
                    }
                }
                else if (faze == 3) {               // pokud už je celý los načten, text se přestane načítat
                    break;
                }
            }
            for (int i = 0; i < vysledky.GetLength(0); i++) {
                if (vysledky[i, 0] == null) {
                    index = i;                              // využití proměnné index pro zjištění počtu načtených zápasů (pole pro průběžné ukládání losu je zbytečně velké)
                    break;
                }
            }
            string[,] vyslednyRozpis = new string[index, 5];                // vytvoření pole o velikosti získaného losu

            for (int i = 0; i < vyslednyRozpis.GetLength(0); i++) {             // přepsání losu do nového pole
                for (int j = 0; j < 5; j++)
                    vyslednyRozpis[i, j] = vysledky[i, j];
            }
            return vyslednyRozpis;
        }

        /// <summary>
        /// Metoda pro získání názvů týmů působích v dané soutěži
        /// </summary>
        /// <param name="losy">Los soutěže</param>
        /// <returns>Pole názvů týmů</returns>
        private string[] NactiTeamy(string[,] losy)
        {
            string teamy = "";
            for (int i = 0; i < losy.GetLength(0); i++) {
                if (teamy.Contains(losy[i, 2]) == false)            // každý nově nalezený tým v losu přidá do textového řetězce
                    teamy = teamy + losy[i, 2] + ";";
            }
            teamy = teamy.Substring(0, teamy.Length - 1);
            string[] vysledek = teamy.Split(';');                   // vrátí pole názvů týmů soutěže
            Array.Sort(vysledek);

            return vysledek;
        }

        /// <summary>
        /// Přepsání názvu instance na název soutěže 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return NazevSouteze;
        }
    }
}
