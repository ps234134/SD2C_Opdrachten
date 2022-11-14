using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeltevreeCore6.Models
{
    public class Dier
    {
        public string ChipId { get; set; }
        public Diersoort Soort { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; }
        public string Ras { get; }
        public Dier(DateTime geboortedatum ,string ras)
        {
            Geboortedatum = geboortedatum;
            Ras = ras;
        }
    }
}
