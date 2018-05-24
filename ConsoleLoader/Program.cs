using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Model;

namespace ConsoleLoader
{
    class Program
    {
        static void Main()
        {

            try
            {
                int radius = 5;
                IFigure figure = new Sphere(radius);

                double Volume = figure.GetVolume();

                Console.WriteLine("Радиус шара: " + radius + ", Объем шара: " + Volume);

                int baseArea = 10;
                int height = 8;

                IFigure figure2 = new Pyramid(baseArea, height);

                double Volume2 = figure.GetVolume();

                Console.WriteLine("Площадь основания параллелепипеда: " + baseArea + ", Высота параллелепипеда: " + height + ", Объем пирамиды: " + Volume2);
  
                int a = 15;
                int b = 12;
                int c = 6;

                IFigure figure3 = new Parallelepiped(a, b, c);

                double Volume3 = figure.GetVolume();

                Console.WriteLine("Стороны параллелепипеда: " + a + "/" + b + "/" + c + ", Объем параллелепипеда: " + Volume3);

                Console.ReadKey();

            }
            catch(FormatException)
            {
                Console.WriteLine("Несоответствие типа");
                Console.ReadKey();
            }
        }
    }
}
