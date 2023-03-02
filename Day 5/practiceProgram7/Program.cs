namespace practiceProgram7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalVal = 0, cntr, xVal;
             Random rndm = new Random();
            for(cntr = 0; cntr <10; cntr++)
            {
                xVal = rndm.Next(1, 11);
                totalVal += xVal;
                Console.WriteLine($"Value of X at position {cntr} is: {xVal}");
            }
            Console.WriteLine($"Total Value of X is: {totalVal}");
            Console.ReadLine();
        }
    }
}