using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.models
{
    public class Land
    {
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        private string naam;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }


    }
}
