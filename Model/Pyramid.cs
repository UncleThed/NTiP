using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Пирамида
    /// </summary>
    public class Pyramid : IFigure
    {
        private int _baseArea;
        private int _height;

        /// <summary>
        /// Площадь основания
        /// </summary>
        public int BaseArea
        {
            get { return _baseArea; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Отрицательная площадь");
                }
                _baseArea = value;
            }
        }
        
        /// <summary>
        /// Высота
        /// </summary>
        public int Height
        {
            get { return _height; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Отрицательная высота");
                }
                _height = value;
            }
        }

        /// <summary>
        /// Конструктор класса Пирамида
        /// </summary>
        /// <param name="baseArea"></param>
        /// <param name="heigth"></param>
        public Pyramid(int baseArea, int heigth)
        {
            BaseArea = baseArea;
            Height = heigth;
        }
        
        /// <summary>
        /// Расчитать объем пирамиды
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            return BaseArea * Height / 3.0;
        }
    }
}
