using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdracht3_Sdlc_W2
{
    public class Klant
    {
        private List<Boeking> boekingen;
        public string Naam{ get; set; }
    }
    public class Boeking
    {
        private Klant klant;
        private Reis reis;
        public DateTime Datum { get; set; }
        public int AantalPersonen { get; set; }

        public double DeelBetaald { get; set; }

        public Boeking(Reis reis)
        {

        }

        public double Prijs()
        {
            return DeelBetaald;
        }
    }

    public class Reis
    {
        private Bestemming bestemmingen;
        public int Dagen { get; set; }
        public double PrijsPpPd{ get; set; }

        public Reis(Bestemming bestemming)
        {

        }
    }

    public class Bestemming
    {
        public string Locatie{ get; set; }
        public string Plaats { get; set; }
        public string Land { get; set; }
    }
}
