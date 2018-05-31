using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Шар
    /// </summary>
    [Serializable]
    public class Sphere : IFigure
    {
        private int _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public int Radius
        {
            get { return _radius; }
            private set
            {
                if (value < 0.0)
                {
                    throw new Exception("Отрицательный радиус");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Конструктор класса Шар
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(int radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Расчитать объем шара
        /// </summary>
        /// <returns></returns>
        public double Volume
        {
            get { return Math.PI * Radius * Radius * Radius * 4.0 / 3.0; }
        }

        /// <summary>
        /// Получить тип фигуры
        /// </summary>
        public string Type
        {
            get { return "Sphere"; }
        }
    }
}
