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
    public class SrpavceSoutezi
    {
        public BindingList<Soutez> Souteze { get; set; }

        public SrpavceSoutezi()
        {
            Souteze = new BindingList<Soutez>();
        }

        public void Pridej(string odkaz)
        {
            if ((odkaz.Contains("stis.ping-pong.cz/tabulka/svaz-") == false) &&
                (odkaz.Contains("rocnik-") == false) && (odkaz.Contains("soutez-") == false))
                throw new ArgumentException("Neplatný odkaz soutěže");

            Soutez soutez = new Soutez(odkaz);
            Souteze.Add(soutez);
        }

        public void Odeber(Soutez soutez)
        {
            Souteze.Remove(soutez);
        }

        public void Uloz()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(@"souteze.xml", settings)) {
                xw.WriteStartDocument();
                xw.WriteStartElement("souteze");

                foreach (Soutez soutez in Souteze) {
                    xw.WriteStartElement("soutez");
                    xw.WriteAttributeString("nazev", soutez.NazevSouteze);
                    xw.WriteAttributeString("url", soutez.OdkazTabulka);                    
                    xw.WriteEndElement();
                }

                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();
            }
        }

        public void Nacti()
        {
            if (File.Exists(@"souteze.xml")) {
                using (XmlReader xr = XmlReader.Create(@"souteze.xml")) {
                    string element = "";
                    string odkaz = "";
                    while (xr.Read()) {
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
