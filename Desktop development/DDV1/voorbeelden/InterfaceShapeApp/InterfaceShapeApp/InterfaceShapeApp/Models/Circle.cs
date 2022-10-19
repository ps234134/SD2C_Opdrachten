using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapeApp.Models
{
    public class Circle : IMeasurable
    {
        private double radius;     
        public double Radius
        { 
            get { return radius; } 
            set { radius = value; } 
        }

        public double CalculateSurface()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
