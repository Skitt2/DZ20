using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = lenghtCircle;
            double x = myDelegate(10);
            Console.WriteLine("Длина окружности равна {0}",x);

            myDelegate = squareCircle;
            x = myDelegate(10);
            Console.WriteLine("Площадь окружности равна {0}", x);

            myDelegate = volumeBall;
            x = myDelegate(10);
            Console.WriteLine("Объем шара равен {0}", x);

            Console.ReadKey();

        }
        static double lenghtCircle(double r) => 2 * Math.PI * r;
        static double squareCircle(double r) => Math.PI * r * r;
        static double volumeBall(double r) => 4 * Math.PI * Math.Pow(r,3)/3;
    }
}
