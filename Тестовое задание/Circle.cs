using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double radius;

        /// <summary>
        /// Radius of the circle (throws argument exception if the value <= 0 )
        /// </summary>
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус круга должен быть больше нуля!");
                }
                radius = value;
            }
        }

        /// <summary>
        /// Calculate the area of the circle
        /// </summary>
        /// <returns>Area of the circle</returns>
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
      
    }
}
