using System;

namespace practiceProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 36;
            double sqrx, sqrty, logrthm;
            sqrx = Math.Pow(x, 2);
            sqrty = Math.Sqrt(y);
            logrthm = Math.Log(x, y);
            Console.WriteLine($"Square of {x} = {sqrx}, \nSquare Root of {y} = {sqrty}, \nValue of {x}Log{y} = {logrthm}");
            Console.ReadLine();
        }
    }
}