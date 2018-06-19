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
        private uint _baseArea;

        [DataMember]
        private uint _height;

        /// <summary>
        /// Площадь основания
        /// </summary>
        public uint BaseArea
        {
            get { return _baseArea; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Отрицательная площадь");
                }
                else
                {
                    _baseArea = value;
                }
            }
        }
        
        /// <summary>
        /// Высота
        /// </summary>
        public uint Height
        {
            get { return _height; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Отрицательная высота");
                }
                else
                {
                    _height = value;
                }
            }
        }

        /// <summary>
        /// Конструктор класса Пирамида
        /// </summary>
        /// <param name="baseArea"></param>
        /// <param name="heigth"></param>
        public Pyramid(uint baseArea, uint heigth)
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
            get { return BaseArea / 3.0 * Height; }
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
