using System;

namespace ConsoleApp41
{
    class Program
    {
        delegate double Operation(double a, double b, double c);

        static void Main(string[] args)
        {
            //Operation del = new Operation(Maximum);
            //object result = del.Invoke(3, 7);
            //Console.WriteLine("Maximum: " + result);

            //del = Minimum;
            //result = del.Invoke(3, 7);
            //Console.WriteLine("Minimum: " + result);
            Console.Write("a - ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b - ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c - ");
            double c = double.Parse(Console.ReadLine());

            Operation del = new Operation(Maximum);
            double result = del.Invoke(a, b, c);
            Console.WriteLine(result);
            del = new Operation(Minimum);
            result = del.Invoke(a, b, c);
            Console.WriteLine(result);

            Console.Read();
        }

        static double Maximum(double a, double b, double c)
        {
            if (a>b&&a>c)
            {
                Console.Write("Max: ");
                return a;
            }
            else if (b>a&&b>c)   
            {
                Console.Write("Max: ");
                return b;
            }
            else
            {
                Console.Write("Max: ");
                return c;
            }
        }

        static double Minimum(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                Console.Write("Min: ");
                return a;
            }
            else if (b < a && b < c)
            {
                Console.Write("Min: ");
                return b;
            }
            else
            {
                Console.Write("Min: ");
                return c;
            }
        }
    }
}
