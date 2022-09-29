using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SDLC1_W2_oefen1
{
    public class AdministratieED
    {
        private List<Abbonee> abbonees;
        public double Abbonnementsprijs { get; set; }

        public void NieuweAbbonee(Abbonee abbonee)
        {
            /*Implementatie*/
        }

        public void StopAbbonement(Abbonee abbonee)
        {
            /*Implementatie*/
        }
    }

    public class Abbonee : Persoon
    {
        private AdministratieED administratieED;
        public string Bankrekening { get;}
        public DateTime Einddatum { get; private set; }

        public Abbonee(string naam, string adres, string woonplaats, string bankrekening)
        {
            Bankrekening = bankrekening;
            Naam = naam;
            Adres = adres;
            Woonplaats = woonplaats;   

        }

        public bool Verlenging(DateTime dateTime)
        {
            return true;
        }
    }

    public class Persoon
    {
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string Woonplaats { get; set; }
    }
}
