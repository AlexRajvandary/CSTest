using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    public class Triangle:Shape
    {
        /// <summary>
        /// If the triangle cannot exists due to the Triangle Inequality Theorem it will throw ArgumentException
        /// </summary>
        /// <param name="a">side</param>
        /// <param name="b">side</param>
        /// <param name="c">side</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if(!CheckSides(A,B,C))
            {
                throw new ArgumentException("Incorrect sides, this triangle does not exsist!");
            }
        }

        double a, b, c;

        /// <summary>
        /// side of a triangle (throws argument exception if the value <= 0)
        /// </summary>
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть отрицательной или нулевой!");
                }
                a = value;
            }
        }
        /// <summary>
        /// side of a triangle (throws argument exception if the value <= 0)
        /// </summary>
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть отрицательной или нулевой!");
                }
                b = value;
            }
        }
        /// <summary>
        /// side of a triangle (throws argument exception if the value <= 0)
        /// </summary>
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть отрицательной или нулевой!");
                }
                c = value;
            }
        }
        /// <summary>
        /// Calculate area of the triangle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {


            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        /// <summary>
        /// неравенство треугольника: 
        /// сумма длин любых двух сторон должна быть больше длины третьей стороны, иначе треугольника не может существовать
        /// </summary>
        /// <param name="a">side of the triangle</param>
        /// <param name="b">side of the triangle</param>
        /// <param name="c">side of the triangle</param>
        /// <returns>True if the triangle exists, false - if not</returns>
        public static bool CheckSides(double a, double b, double c)
        {
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if (a + b <= c || a + c <= b || b + c <= a)
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            List<double> sides = new List<double>();
            sides.Add(A);
            sides.Add(B);
            sides.Add(C);
            double max = sides.Max();
            sides.Remove(max);
            return Math.Pow(max, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
