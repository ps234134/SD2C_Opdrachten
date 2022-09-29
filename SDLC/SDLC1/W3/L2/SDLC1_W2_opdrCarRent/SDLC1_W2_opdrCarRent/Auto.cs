using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLC1_W2_opdrCarRent
{
    public abstract class Auto
    {
        public string Kenteken { get;}
        public string Model { get;}
        public bool Inzetbaar { get; set; }   
    }

    public class CarRent
    {
        private List<Auto> autos;
        private List<Chauffeur> chauffeurs;
        public string Naam { get; set; }
        public bool Verhuur(Auto auto, DateTime Datum)
        {
            return true;
        }

        public bool Verhuur(Chauffeur chauffeur, DateTime Datum)
        {
            return true;
        }

        public bool Retounneer(Auto auto)
        {
            return true;
        }

        public bool Retounneer(Chauffeur chauffeur)
        {
            return true;
        }

        

    }

    public class Chauffeur
    {
        public int Personeelsnummer { get; set; }
        public string Naam { get; set; }
        public Chauffeur(string naam)
        {

        }
    }

    public class Standaard : Auto
    {
        public bool TrekhaakAanwezig { get; set; }
        public Standaard(string kenteken, string model, bool trekhaakAanwezig)
        {

        }
    }

    public class Limousine : Auto
    {
        public bool MinibarAanwezig { get; set; }
        public Limousine(string kenteken, string model, bool minibarAanwezig)
        {

        }
    }

    public class _4WD : Auto
    {
        public _4WD(string kenteken, string model)
        {

        }
    }

    public class Vrachtwagen : Auto
    {
        public int Laadvermogen { get; set; }
        public Vrachtwagen(string kenteken, string model, int laadvermogen)
        {

        }

    }

}
