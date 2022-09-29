using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLC1_W2_opdr_planeten
{
    public class Bol
    {
        public double Diameter { get; set; }
        public double Omtrek() { return 0.0; }
        public double Oppervlakte() { return 0.0; }
        public double Inhoud() { return 0.0; }
    }

    public class Ster : Bol
    {
        private List<Planeet> planeten;
        public string Naam { get; set; }

        public Ster(string naam, double diameter)
        {
            this.Naam = naam;
            this.Diameter = diameter;
        }

    }

    public class Planeet : Bol
    {
        private List<Maan> manen;
        private Ster ster;
        public string Naam { get; set; }
        public int Rangnummer { get; set; }
        public double Omlooptijd { get; set; }

        public Planeet(string naam, double diameter)
        {
            Naam = naam;
            Diameter = diameter;
        }
    }

    public class Maan : Bol
    {
        private Planeet planeet;
        public string Naam {get; set; }
        public int Rangnummer { get; set; }
        public double Omlooptijd { get; set; }

        public Maan(string naam, double diameter)
        {
            Naam = naam;
            Diameter = diameter;
        }

    }
}
