namespace practiceProgram5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cntr = 0;

            while(true)
            {
                cntr++;
                if (cntr > 10)
                {
                    break;
                }
                else if((cntr%2) == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"..{cntr}..");
                }
            }
            Console.ReadLine();
        }
    }
}