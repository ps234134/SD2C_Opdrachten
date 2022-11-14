using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeltevreeCore6.Models
{
    public class Verblijf
    {
        public DateTime Van { get; } = default;
        public DateTime Tot { get; private set; } = default;
        public double Administratiekosten { get; private set; } = 0.0;
        public double Behandelingskosten { get; private set; } = 0.0;
        public bool Betaald { get; set; } = false;

        private Eigenaar? eigenaar = null;
        private Dier? dier = null;

        public Verblijf(Eigenaar eigenaar, Dier dier, DateTime van, DateTime tot)
        {
            this.eigenaar = eigenaar;
            this.dier = dier;
            Van = van;
            Tot = tot;
        }

        public void Verlengen(DateTime tot)
        {
            Tot = tot;
            Administratiekosten += Tarieven.Administratiekosten;
        }
        public void Annuleren()
        {
            Tot = DateTime.Now;
            if (Van > Tot) Tot = Van;
            Administratiekosten += Tarieven.Administratiekosten;
        }

        public void Behandelen(SoortBehandeling soort)
        {
            switch (soort)
            {
                case SoortBehandeling.Parasietbehandeling: Behandelingskosten += Tarieven.Parasietbehandeling; break;
                case SoortBehandeling.Inenten: Behandelingskosten += Tarieven.Inenting; break;
                case SoortBehandeling.Chippen: Behandelingskosten += Tarieven.Chippen; break;
                case SoortBehandeling.UitlaatService: Behandelingskosten += Tarieven.UitlaatService; break;
            }
        }
        public double TotaalPrijs()
        {
            if(dier.Soort == Diersoort.Hond)
            {
                double verblijfkosten = (Tot - Van).Days * Tarieven.DagprijsHond;
                return verblijfkosten + Administratiekosten + Behandelingskosten;
            }
            else if(dier.Soort == Diersoort.Kat)
            {
                double verblijfkosten = (Tot - Van).Days * Tarieven.DagprijsKat;
                return verblijfkosten + Administratiekosten + Behandelingskosten;
            }
            else
            {
                double verblijfkosten = (Tot - Van).Days * Tarieven.DagprijsKonijn;
                return verblijfkosten + Administratiekosten + Behandelingskosten;
            }

        }
    }

   
}
