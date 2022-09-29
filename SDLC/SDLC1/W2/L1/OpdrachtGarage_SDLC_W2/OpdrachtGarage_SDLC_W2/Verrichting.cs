using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtGarage_SDLC_W2
{
    public enum SoortVerrichting { 
        KleineBeurt,
        GroteBeurt,
        Spoedreparatie,
        APK,
        HulpOnderweg

    }

    public class Verrichting
    {
        private Auto auto;
        public SoortVerrichting Soort { get; set; }
        public DateTime Datum { get; set; }
        public double Werktijd { get; set; }

        public double  Reistijd { get; set; }

        public double Materialen { get; set; }

        

        public Verrichting(Auto auto)
        {
            /*implementatie*/
        }
    }

    public class Auto
    {
        private Contact eigenaar;
        private Contact gebruiker;
        private List<Verrichting> verrichtingen;
        public string Kenteken { get;}
        public int KmStand { get; set; }
        public DateTime VolgendeAPK { get; set; }

        public Auto(string kenteken, Contact eigenaar, Contact gebruiker ,int kmStand)
        { 
            /*implementatie*/
        }

        public void NieuweVerrichting(Verrichting verrichting)
        {
            /*implementatie*/
        }
    }

    public class Contact
    {
        public string Naam { get;}

        public Contact(string naam)
        {
            /*implementatie*/
        }
    }

    

}
