using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace unittestWPF
{
    public class Bankrekening
    {
        public double Saldo { get; private set; } = 0.0;
        public bool Bevroren { get; set; } = false;
        public Bankrekening(double startbedrag)
        {
            Saldo = startbedrag;
        }
        public Bankrekening()
        {
        }
        public void Opnemen(double bedrag)          // verlaag saldo
        {
            if(bedrag < 0.0) return;
          
            if (Bevroren) return;
 
            Saldo -= bedrag;
        }
        public void Storten(double bedrag)          // verhoog saldo
        {
            if (bedrag < 0.0)return;
            
            Saldo += bedrag;
        }


    }

}
