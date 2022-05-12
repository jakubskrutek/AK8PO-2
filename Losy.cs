using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO_2
{
    public class Losy
    {
        public string[,] Los;

        public string[] Muzstva;

        public Losy()
        {
        }

        /*public string[] NactiOddily(string odkaz)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData(odkaz);
            string data = System.Text.Encoding.UTF8.GetString(raw);
            string retezec = "";
            int index = odkaz.IndexOf("soutez");
            string soutez = odkaz.Substring(index) + "\">";
            bool nacitani = false;
            string[] vysledky = new string[100];
            byte ridiciPromenna = 0;

            foreach (char znak in data) {
                retezec += znak;
                if ((retezec.Contains("Mapa heren") == true) && nacitani == false) {
                    retezec = "";
                    nacitani = true;
                }
                if (nacitani == true) {
                    if ((retezec.Contains(soutez)) && retezec.Contains("</a>\n")) {
                        vysledky[ridiciPromenna] = retezec.Substring(retezec.IndexOf(soutez) + soutez.Length);
                    }
                }

            }



            string[] test = {"0"};
            return test;
        }*/
    }
}
