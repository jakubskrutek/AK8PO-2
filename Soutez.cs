﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO_2
{
    public class Soutez
    {
        public string OdkazTabulka { get; set; }

        public string NazevSouteze { get; set; }

        public string OdkazLos { get; set; }

        public string OdkazZapis { get; set; }

        public string OdkazUspesnost { get; set; }

        public Soutez (string odkaz)
        {
            OdkazTabulka = odkaz;
            NazevSouteze = ZiskejNazevSouteze(odkaz);
        }

        private string ZiskejNazevSouteze(string odkaz)
        {            
            odkaz = odkaz.Replace("tabulka", "los-vse");

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://stis.ping-pong.cz/los-vse/svaz-420703/rocnik-2021/soutez-4441");
            string data = System.Text.Encoding.UTF8.GetString(raw);

            int index = odkaz.IndexOf("soutez-") + 7;
            string cisloSouteze = odkaz.Substring(index);
            index = data.IndexOf(cisloSouteze) + 6;
            string nazevSouteze = data.Substring(index, 100);
            index = nazevSouteze.IndexOf('<');
            nazevSouteze = nazevSouteze.Substring(0, index).Trim();

            index = odkaz.IndexOf("rocnik-");
            int rocnik = int.Parse(odkaz.Substring(index + 7, 4));
            nazevSouteze = nazevSouteze + " - " + rocnik.ToString() + "/" + (rocnik + 1).ToString();

            return nazevSouteze;
        }

        public override string ToString()
        {
            return NazevSouteze;
        }
    }
}
