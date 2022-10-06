using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindCore6.Model
{
    public class Uitslag
    {
        public string Poging { get; private set; }
        public int Posities { get; private set; }
        public int Aantal { get; private set; }
        private int beurt;

        public Uitslag(int beurt, string poging, int pos, int aantal)
        {
            this.beurt = beurt + 1;
            Poging = poging;
            Posities = pos;
            Aantal = aantal;
        }
        public override string ToString()
        {
            return $"{beurt} \t {Poging} \t\t {Posities} \t {Aantal}";
        }

    }
}
