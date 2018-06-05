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
        private int _a;

        [DataMember]
        private int _b;

        [DataMember]
        private int _c;

        /// <summary>
        /// Сторона A
        /// </summary>
        public int A
        {
            get { return _a; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Длинна стороны параллелелепипеда должна быть больше нуля");
                }
                _a = value;
            }
        }

        /// <summary>
        /// Сторона B
        /// </summary>
        public int B
        {
            get { return _b; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Длинна стороны параллелелепипеда должна быть больше нуля");
                }
                _b = value;
            }
        }

        /// <summary>
        /// Сторона C
        /// </summary>
        public int C
        {
            get { return _c; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Длинна стороны параллелелепипеда должна быть больше нуля");
                }
                _c = value;
            }
        }

        /// <summary>
        /// Конструктор класса Параллелепипед
        /// </summary>
        /// <param name="baseArea"></param>
        /// <param name="heigth"></param>
        public Parallelepiped(int a, int b, int c)
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
            get { return A * B * C; }
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
