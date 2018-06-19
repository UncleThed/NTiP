using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// Параллелепипед
    /// </summary>
    [DataContract]
    public class Parallelepiped : IFigure
    {
        [DataMember]
        private uint _a;

        [DataMember]
        private uint _b;

        [DataMember]
        private uint _c;

        /// <summary>
        /// Сторона A
        /// </summary>
        public uint A
        {
            get { return _a; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Длинна стороны параллелелепипеда должна быть больше нуля");
                }
                else
                {
                    _a = value;
                }
            }
        }

        /// <summary>
        /// Сторона B
        /// </summary>
        public uint B
        {
            get { return _b; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Длинна стороны параллелелепипеда должна быть больше нуля");
                }
                else
                {
                    _b = value;
                }
            }
        }

        /// <summary>
        /// Сторона C
        /// </summary>
        public uint C
        {
            get { return _c; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Длинна стороны параллелелепипеда должна быть больше нуля");
                }
                else
                {
                    _c = value;
                }
            }
        }

        /// <summary>
        /// Конструктор класса Параллелепипед
        /// </summary>
        /// <param name="baseArea"></param>
        /// <param name="heigth"></param>
        public Parallelepiped(uint a, uint b, uint c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Расчитать площадь параллелепипеда
        /// </summary>
        /// <returns></returns>
        public double Volume
        {
            get { return (double)A * B * C; }
        }

        /// <summary>
        /// Получить тип фигуры
        /// </summary>
        public string Type
        {
            get { return "Parallelepiped"; }
        }
    }
}
