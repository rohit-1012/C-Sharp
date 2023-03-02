namespace practiceProgram9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal decVal;
            long longVal;
            Console.Write("Enter a Decimal value: ");
            decVal = Convert.ToDecimal(Console.ReadLine());
            longVal = Convert.ToInt64(decVal);
            Console.WriteLine($"Entered Decimal value is: {decVal} and it's Value converted to Long is: {longVal}");
            Console.ReadLine();
        }
    }
}