using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задача");
            Console.WriteLine("Введите значения");
            int a = Convert.ToInt32(Console.ReadLine());
            double rezult = a - 10 * Math.Sin(a) + Math.Abs(Math.Pow(a, 4) - Math.Pow(a, 5));           
            Console.WriteLine(Math.Round(rezult, 3));
            Console.WriteLine("2 задача");
            Console.WriteLine("Введите значения");
            
            double l = Convert.ToDouble(Console.ReadLine());
            double r = l / (2 * Math.PI);
            double s = Math.PI * r * r;
            Console.WriteLine("Площадь круга = " + Math.Round(s, 3));
            Console.ReadLine();
        }
    }
}
