using System;

namespace _6._7
{
    class Program
    {
        static double V(string A, double Min = -1.7E308, double Max = 1.7E308, double E = 1.7E308, double E2 = 1.7E308)
        {
            Console.WriteLine($"Введите {A}:");
            double B;
            while (!(double.TryParse(Console.ReadLine(), out B) && B >= Min && B <= Max && B != E && B != E2)) Console.WriteLine($"Неверно {A}");
            return B;
        }
        static void Main(string[] args)
        {

            int C = 0;
            int D = 1;
            int X = 1;
            while (X != 0)
            {
                C++;
                D *= X;
                X = (int)V($"число a{C}");
            }
            Console.WriteLine(D);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
