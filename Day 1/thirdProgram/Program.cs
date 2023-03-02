namespace thirdProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 0; x < 10; x++)
            {
                for (y = 0; y < 10; y++)
                {
                    Console.Write("X");
                    Console.Write($"{(char)1}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}