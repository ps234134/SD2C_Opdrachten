using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapeApp.Models
{
    public class Square : IMeasurable
    {
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double CalculateSurface()
        {
            return height * width;
        }
    }
}
