using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO_2
{
    class SpavceSoutezi
    {
        public BindingList<Soutez> Souteze { get; set; }

        public SpavceSoutezi()
        {
            Souteze = new BindingList<Soutez>();
        }

        public void Pridej(string odkaz)
        {
            if ((odkaz.Contains("stis.ping-pong.cz/tabulka/svaz") == false) &&
                (odkaz.Contains("rocnik") == false) && (odkaz.Contains("soutez") == false))
                throw new ArgumentException("Neplatný odkaz soutěže");

            Soutez soutez = new Soutez(odkaz);
            Souteze.Add(soutez);
        }

        // odeber bude jako aktualizuj
    }
}
