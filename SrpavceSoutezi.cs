using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if ((odkaz.Contains("stis.ping-pong.cz/tabulka/svaz") == false) &&
                (odkaz.Contains("rocnik") == false) && (odkaz.Contains("soutez") == false))
                throw new ArgumentException("Neplatný odkaz soutěže");

            Soutez soutez = new Soutez(odkaz);
            Souteze.Add(soutez);
        }

        public void Odeber(Soutez soutez)
        {
            Souteze.Remove(soutez);
        }

        // odeber bude jako aktualizuj
    }
}
