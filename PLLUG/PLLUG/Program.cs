using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLLUG
{    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розмір холодильника");
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Через що ви спробуєте пронести холодильник? \n1 - вікно \n2 - двері");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть тип " + (key == 1 ? "вікна." : "дверей.") + " \n1 - Круглі \n2 - Прямокутні");
            int key2 = int.Parse(Console.ReadLine());
            if (key2 == 2)
            {
                Console.WriteLine("Введіть розмір " + (key == 1 ? "вікна." : "дверей."));
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                if (height < a && width < b || height < a && length < b ||
                    height < b && width < a || height < b && length < a ||
                    width < a && length < b || width < b && length < a)
                {
                    Console.WriteLine("Проходить");
                }
                else
                {
                    Console.WriteLine("Не проходить");

                }
            }
            if (key2 == 1)
            {
                Console.WriteLine("Введіть діаметр " + (key == 1 ? "вікна." : "дверей."));
                double diametr = double.Parse(Console.ReadLine());
                if (Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2)) < diametr ||
                    Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2)) < diametr ||
                    Math.Sqrt(Math.Pow(height, 2) + Math.Pow(length, 2)) < diametr)
                {
                    Console.WriteLine("Проходить");
                }
                else
                {
                    Console.WriteLine("Не проходить");
                }
            }
            Console.ReadKey();
        }
    }
}
