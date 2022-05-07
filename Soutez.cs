using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO_2
{
    public class Soutez
    {
        public string Odkaz { get; set; }

        public string NazevSouteze { get; set; }

        public Soutez (string odkaz)
        {
            Odkaz = odkaz;
            NazevSouteze = ZiskejNazevSouteze(odkaz);
        }

        private string ZiskejNazevSouteze(string odkaz)
        {
            if ((odkaz.Contains("stis.ping-pong.cz/tabulka/svaz") == false) &&
                (odkaz.Contains("rocnik") == false) && (odkaz.Contains("soutez") == false))
                throw new ArgumentException("Neplatný odkaz soutěže");

            odkaz.Replace("tabulka", "los-vse");

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://stis.ping-pong.cz/los-vse/svaz-420703/rocnik-2021/soutez-4441");
            string data = System.Text.Encoding.UTF8.GetString(raw);

            int index = data.IndexOf("Los a výsledky - Soutěž ");
            string nazevSouteze = data.Substring(index + 24, 100);
            index = nazevSouteze.IndexOf("\t");
            nazevSouteze = nazevSouteze.Substring(0, index).Trim();

            index = odkaz.IndexOf("rocnik-");
            int rocnik = int.Parse(odkaz.Substring(index + 7, 4));
            nazevSouteze = nazevSouteze + " - " + rocnik.ToString() + "/" + (rocnik + 1).ToString();

            return nazevSouteze;
        }
    }


}
