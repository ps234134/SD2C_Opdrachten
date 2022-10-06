using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLC_W4_Demo
{
    public class Rekenaar

    {

        public int A { get; set; }

        public int B { get; set; }

        public Operator Operator { get; set; }

        public Rekenaar()

        {

            A = 0;

            B = 0;

        }

        public int Uitslag()

        {

            switch (Operator)

            {

                case Operator.Plus: return A + B;

                case Operator.Min: return A - B;

                case Operator.Maal: return A * B;

            }

            return 0;

        }

    }
}
