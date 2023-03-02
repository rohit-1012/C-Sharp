namespace practiceProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 1, val2 = 0;
            Console.WriteLine("Getting ready to do the IF Statement...");
            if (val1 == val2)
            {
                Console.WriteLine("IF Statement 1 executed!");
            }

            if (val1 != val2)
            {
                Console.WriteLine("IF Statement 2 executed!");
            }
            Console.WriteLine("Done with IF Statement.");
            Console.ReadLine();
        }
    }
}