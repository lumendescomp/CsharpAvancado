using System;

namespace DelegatesGeneric
{
    class Program
    {
        delegate T Calc<T>(T a, T b);
        static void Main(string[] args)
        {
            Calc<int> calc = new Calc<int>(Somar);
            Calc<decimal> calcD = new Calc<decimal>(SomarDec);
            Console.Write(calc(2, 2));
            Func<int, int, int> calc2 = Somar;
            Console.WriteLine(calc2(1, 5));
            Console.ReadKey();

        }

        static int Somar(int a, int b)
        {
            return a + b;
        }
        static decimal SomarDec(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
