using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {

        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double getCircumference()
        {
            double pi = Math.PI;
            return 2 * pi * Radius;

        }
        
        public double getArea()
        {
            double pi = Math.PI;
            return pi * (Radius*Radius);

        }

        private Double formatNumber(double x)
        {
            return Math.Round(x, 2);
        }

        public double getFormattedCircumference()
        {
            double pi = Math.PI;
            double uCirc = 2 * pi * Radius;
            return formatNumber(uCirc);
            
        }

        public double getFormattedArea()
        {
            double pi = Math.PI;
            double uArea = pi * (Radius * Radius);
            return formatNumber(uArea);
           


        }

    }
}
