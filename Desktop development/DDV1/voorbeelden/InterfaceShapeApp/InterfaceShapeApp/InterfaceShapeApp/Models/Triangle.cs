using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapeApp.Models
{
    public class Triangle : IMeasurable
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double CalculateSurface()
        {
            return length * length / 2;
        }
    }
}
