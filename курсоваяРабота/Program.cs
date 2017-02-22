using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсоваяРабота
{
    class Program
    {
        static double intFunk(double x)
        {
            return (Math.Pow(x, 2) * Math.Sqrt(4 - Math.Pow(x, 2)));
        }

        static double calcIntegral(double a, double b, double n)
        {
            double h, result;

            result = 0.0;

            h = (b - a) / n;

            for (int i = 0; i < n; i++)
            {
                result += intFunk(a + h * (i + 0.5));
            }
            result *= h;
            return result;
        }

        static void Main(string[] args)
        {
            double integral;

            int a1, b1, n1;

            Console.Write("Введите нижний предел: ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите верхний предел: ");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите шаг: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            integral = calcIntegral(a1, b1, n1);
            Console.WriteLine("Значение интеграла = {0}", integral);
            Console.ReadKey();

        }
    }
}
