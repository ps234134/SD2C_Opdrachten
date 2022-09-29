using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdracht2_Sdlc_W2
{
    public class VerhuurBedrijf
    {
        private List<VerhuurStation> verhuurstations;
        public void NieuwVerhuurStation(VerhuurStation verhuurstation)
        {
            /*implementatie*/
        }
    }

    public class VerhuurStation
    {
        private List<Huurauto> huurautos;
        public string Locatie { get;}

        public VerhuurStation(string locatie)
        {
            /*implementatie*/   
        }
        public void NieuweHuurauto(string kenteken)
        {
            /*implementatie*/
            
              
        }
    }

    public class Huurauto
    {
        private VerhuurStation verhuurstation;
        public string Kenteken { get; }

        public Huurauto(string kenteken, VerhuurStation verhuurStation)
        {
            /*implementatie*/
        }

        public bool VerhuurAuto()
        {
            return true;
        }
    }
}
