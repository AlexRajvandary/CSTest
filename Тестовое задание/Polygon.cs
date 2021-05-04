using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    /// <summary>
    /// Позволяет посчитать площадь любого многоугольника с известными координатами его точек
    /// Allows you to calculate the area for a polygon with any number of points 
    /// using the coordinates of the points of the polygon
    /// </summary>
    // ---------------------------------------------------------------------------------------
    // не очень понятно треование "Вычисление площади фигуры без знания типа фигуры", сначала я хотел создаь класс взаимодейтсвия с пользователем с 3 перегрузками конструктора,
    // где взависимости от передаваемых параметров мы создаем разную фигуру (если в параметрах только 1 double -> создаем Circle, если 3 double -> Triangle, если массив координат точек -> Polygon),
    // и затем добавлять созданную фигуру в коллекцию фигур чтобы далее пользователь сам решил, что ему нужно. Но такой вариант показался мне неверным.
    // Данный класс позволяет посчитать площадь любого многоугольника,что также удовлетворяет требованию "Вычисление площади фигуры без знания типа фигуры"
    public class Polygon : Shape
    {

        public Polygon((double, double)[] cordinates)
        {
            Cordinates = cordinates;
        }
        private (double, double)[] cordinates;
        /// <summary>
        /// Cordinates of the polygon's points
        /// </summary>
        public (double, double)[] Cordinates
        {
            get
            {
                return cordinates;
            }
            set
            {
                if (value.Length == 0) throw new ArgumentException("There are no points!");
                else if (value.Length - value.Distinct().ToArray().Length != 0)
                {
                    throw new ArgumentException("All elements have to be unique! (All points must be different )");
                }
                else
                {
                    cordinates = value;
                }

            }
        }
        /// <summary>
        /// Calculate area of any polygon
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double sum = 0;
            double sum2 = 0;
            for (int i = 0; i < cordinates.Length; i++)
            {
                sum += cordinates[i].Item1 * cordinates[(i + 1) % cordinates.Length].Item2;
                sum2 += cordinates[i].Item2 * cordinates[(i + 1) % cordinates.Length].Item1;
            }
            return (sum - sum2) / 2.0;
        }

      

    }
  
}
