namespace practiceProject6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalVal = 0, cntr = 1, xVal;
            Random rndm = new Random();
            do
            {
                xVal = rndm.Next(1, 11);
                totalVal += xVal;
                Console.WriteLine($"Value of X at index {cntr} is: {xVal}");
                cntr++;
            }while(cntr < 10);
            Console.WriteLine($"Total value of X is: {totalVal}");
            Console.ReadLine();
        }
    }
}