    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLC1_W2_oefen2
{
    public class Speelveld
    {
        private List<Batje> batjes;
        private Bal bal;
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public Batje Balgeraakt() { return null; }

    }

    public class Bal
    {

        public int X { get; set; }
        public int Y { get; set; }

        public int Richting { get; set; }

        public void NieuweRichting()
        {

        }
    }

    public class Batje
    {
        private Speler spelers;
        public int X { get; private set; }
        public int Y { get; private set; }

        public void NieuwePositie(int x, int y)
        {
           
            
        }
    }

    public class Speler
    {
        public string naam { get; set; }
        public int Score { get; private set; }

        public void VerhoogScore()
        {
            Score = 0;
        }
    }

    public class Mens : Speler
    {
        public int Levens { get; private set; }
        public Mens(string naam, int levens)
        {
            naam = naam;
            Levens = levens;

        }
        public void VerlaagLevens() { }
    }

    public class Robot : Speler
    {
        public int Niveau{ get; set; }
        public Robot(string naam, int niveau)
        {
            naam = naam;
            Niveau = niveau;
        }
    }  
}
