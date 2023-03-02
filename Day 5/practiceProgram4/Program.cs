namespace practiceProgram4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalVal = 0, cntr = 1, xVal;
            Random rndm = new Random();

            while(cntr <= 10)
            {
                xVal = rndm.Next(1, 11);
                totalVal += xVal;
                cntr++;
                Console.WriteLine($"Value of X is: {xVal} and new Total Value is: {totalVal}");
            }
            Console.WriteLine($"Final Total Value is: {totalVal}");
            Console.WriteLine($"Average of the Numbers is: {totalVal / cntr}");
            Console.ReadLine();
        }
    }
}