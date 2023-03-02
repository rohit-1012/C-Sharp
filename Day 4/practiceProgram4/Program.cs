namespace practiceProgram4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 1, val2 = 0, result;

            result = (val1 == val2) ? 1 : 0;
            Console.WriteLine($"The result is: {result}");

            val2 = 1;
            result = (val1 == val2) ? 1 : 0;
            Console.WriteLine($"The updated result is: {result}");
            Console.ReadLine();
        }
    }
}