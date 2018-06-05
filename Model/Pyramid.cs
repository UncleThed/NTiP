using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// Пирамида
    /// </summary>
    [DataContract]
    public class Pyramid : IFigure
    {
        [DataMember]
        private int _baseArea;

        [DataMember]
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
        public double Volume
        {
            get { return BaseArea * Height / 3.0; }
        }

        /// <summary>
        /// Получить тип фигуры
        /// </summary>
        public string Type
        {
            get { return "Pyramid"; }
        }
    }
}
