using System;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// Шар
    /// </summary>
    [DataContract]
    public class Sphere : IFigure
    {
        [DataMember]
        private uint _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public uint Radius
        {
            get { return _radius; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Отрицательный радиус");
                }
                else
                {
                    _radius = value;
                }
            }
        }

        /// <summary>
        /// Конструктор класса Шар
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(uint radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Расчитать объем шара
        /// </summary>
        /// <returns></returns>
        public double Volume
        {
            get { return 4.0 / 3 * Math.PI * Radius * Radius * Radius; }
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
