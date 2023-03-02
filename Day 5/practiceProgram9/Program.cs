namespace practiceProgram9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 3;
            if (x < 2) if (y == 3) x = 5; else x = 9;
            Console.WriteLine(x + " " + y);
            Console.ReadLine();
        }
    }
}