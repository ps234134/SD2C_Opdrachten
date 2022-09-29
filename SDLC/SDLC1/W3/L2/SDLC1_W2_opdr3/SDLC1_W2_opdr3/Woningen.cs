using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLC1_W2_opdr3
{
    public abstract class Woningen
    {
        public string Adres { get; }

        public double Inhoud { get; set; }
        public int Slaapkamers { get; set; }
  
    }

    public class Persoon
    {
        public string Naam { get; }

        public Persoon(string naam)
        {
            Naam = naam;    
        }
    }

    public class Huurwoning : Woningen
    {
        private Persoon huurder;
        private Persoon eigenaar;

        public double Huurprijs { get; set; }

        public Huurwoning(string adres, double inhoud, int slaapkamers, double huurprijs)
        {

        }

    }

    public class Koopwoning : Woningen
    {
        private Persoon eigenaar;
        public bool  TeKoop { get;}
        public double Koopprijs { get; set; }

        public Koopwoning(string adres, double inhoud, int slaapkamers, double koopprijs )
        {

        }
    }
}


