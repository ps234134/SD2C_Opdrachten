using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindCore6.Model
{
    public class MM
    {
        public string TeRaden { get; set; }
        public int Beurt { get; set; }
        public string Poging { get; set; }
        private Random r = new Random();

        // NieuwSpel
        /// <summary>
        /// Start nieuw spel, Beurt wordt 0. TeRaden wordt nieuw getal.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        public void NieuwSpel()
        {
            Beurt = 0;
            TeRaden = "";
            char[] mogelijkheden = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char teradencijfer;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    int x = r.Next(10);
                    teradencijfer = mogelijkheden[x];
                    mogelijkheden[x] = 'x';
                } while (teradencijfer == 'x');
                TeRaden += teradencijfer;
            }
        }

        // NieuweBeurt
        /// <summary>
        /// Beurt wordt opgehoogd
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        public void NieuweBeurt()
        {
            Beurt++;
        }

        // NieuwePoging
        /// <summary>
        /// Neemt ingevoerde poging over, corrigeert aantal cijfers in poging.
        /// </summary>
        /// <param name="p">string, bevat de ingevoerde poging</param>
        public void NieuwePoging(string p)
        {
            while (p.Length < 4) p = "0" + p;
            if (p.Length > 4) p = p.Remove(4);
            Poging = p;
        }
        // PositiesOK
        /// <summary>
        /// Bereken aantal correcte posities van poging in TeRaden.
        /// </summary>
        /// <returns>
        /// integer, aantal cijfers op de juiste positie
        /// </returns>

        public int PositiesOK()
        {
            int pos = 0;
            for (int i = 0; i < 4; i++) if (TeRaden[i] == Poging[i]) pos++;
            return pos;
        }

        // AantalOK
        /// <summary>
        /// Bereken aantal correcte cijfers van Poging in TeRaden
        /// </summary>
        /// <returns>
        /// integer, aantal correcte cijfers
        /// </returns>
        public int AantalOK()
        {
            int aan = 0;
            string x = TeRaden;
            for (int i = 0; i < 4; i++)
            {
                int y = x.IndexOf(Poging[i]);
                if (y >= 0)
                {
                    aan++;
                    x = x.Remove(y, 1);
                }
            }
            return aan;
        }
    }
}
