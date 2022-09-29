using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1_Sdlc_W2
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

    public class Abbonee
    {
        private AdministratieED administratieED;
        
        public string Name { get; }
        public string Adres { get; set; }
        public string Woonplaats { get; set; }
        public string bankrekening { get;}
        public DateTime EindDatum{ get;}

        public Abbonee(string naam, string adres, string woonplaats, string bankrekening, DateTime einddatum)
        {
            /*implementatie*/
        }

        public bool Verlenging(DateTime einddatum)
        {
            return true;
        }


    }
}
