using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeltevreeCore6.Models
{
    public class Eigenaar
    {
        public string Naam { get; }
        public string Adres { get; set; }
        public string Telefoon { get; set; }
        public string Bankrekening { get; set; }
        public Eigenaar(string naam)
        {
            Naam = naam;
        }
    }
}
