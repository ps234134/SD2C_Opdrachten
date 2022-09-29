using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdlc_W2
{
    public class Zanger
    {
        private List<Lied> liederen;

        public string Naam { get; set; }
        
        public Zanger(string naam)
        {
            /* implementatie */  
        }

        public void  AddLied(Lied lied)
        {
            /* implementatie */
        }

    }

    public class Lied
    {

        private Zanger zanger;
        public string Naam { get; set; }

        public Lied(string naam, Zanger zanger)
        {
            /* implementatie */
        }
    }

    public class Liederenlijst
    {
        private List<Lied> liederen;

        public string Naam { get; set; }

        public Liederenlijst(string naam)
        {
            /* implementatie */
        }

        public void AddLied(Lied lied)
        {
            /* implementatie */
        }

        public void RemoveLied(Lied lied)
        {
            /* implementatie */
        }
    }
}
