using System;

namespace Delegates
{
    class Program
    {
        public delegate int ExecutarCalc(int a, int b);

        static void Result(int a, int b, ExecutarCalc del)
        {
            int resultado = del(a, b);
            Console.WriteLine(string.Format("O resultado é {0}", resultado));
            Console.ReadKey();
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {

            Result(3, 3, Somar);
        }

    }
}
