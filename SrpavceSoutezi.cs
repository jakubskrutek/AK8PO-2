using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AK8PO_2
{
    /// <summary>
    /// Třída pro správu vytvořených instancí soutěží
    /// </summary>
    public class SrpavceSoutezi
    {
        /// <summary>
        /// List pro ukládání soutěží
        /// </summary>
        public BindingList<Soutez> Souteze { get; set; }

        /// <summary>
        /// Kostruktor listu soutěží
        /// </summary>
        public SrpavceSoutezi()
        {
            Souteze = new BindingList<Soutez>();
        }

        /// <summary>
        /// Metoda pro přidání nové soutěže do listu
        /// </summary>
        /// <param name="odkaz">Webový odkaz na soutěž</param>
        public void Pridej(string odkaz)
        {
            if ((odkaz.Contains("stis.ping-pong.cz/tabulka/svaz-") == false) &&
                (odkaz.Contains("rocnik-") == false) && (odkaz.Contains("soutez-") == false))
                throw new ArgumentException("Neplatný odkaz soutěže");

            Soutez soutez = new Soutez(odkaz);
            Souteze.Add(soutez);
        }

        /// <summary>
        /// Metoda pro odebrání soutěže z listu
        /// </summary>
        /// <param name="soutez">Objekt soutěž</param>
        public void Odeber(Soutez soutez)
        {
            Souteze.Remove(soutez);
        }

        /// <summary>
        /// Metoda pro uložení seznamu soutěží do xml souboru
        /// </summary>
        public void Uloz()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(@"souteze.xml", settings)) {
                xw.WriteStartDocument();
                xw.WriteStartElement("souteze");

                foreach (Soutez soutez in Souteze) {
                    xw.WriteStartElement("soutez");
                    xw.WriteAttributeString("nazev", soutez.NazevSouteze);              // uloží název soutěže a odkaz na ni
                    xw.WriteAttributeString("url", soutez.OdkazTabulka);                    
                    xw.WriteEndElement();
                }

                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();
            }
        }

        /// <summary>
        /// Metoda pro načtení soutěže z xml souboru
        /// </summary>
        public void Nacti()
        {
            if (File.Exists(@"souteze.xml")) {
                using (XmlReader xr = XmlReader.Create(@"souteze.xml")) {
                    string element = "";
                    string odkaz = "";
                    while (xr.Read()) {                                         // načte odkaz a znovu naparsuje los - soutěž je při každém otevření aplikace aktuální
                        if (xr.NodeType == XmlNodeType.Element) {
                            element = xr.Name;
                            if (element == "soutez")
                                odkaz = xr.GetAttribute("url");
                        }
                        if (odkaz != "") {
                            Pridej(odkaz);
                            odkaz = "";
                        }                            
                    }
                }
            }
        }
    }
}
