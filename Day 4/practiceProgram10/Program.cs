namespace practiceProgram10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intch;
            char charVal;
            Console.Write("Enter an integer value: ");
            intch = Convert.ToInt32(Console.ReadLine());
            charVal = Convert.ToChar(intch);
            Console.WriteLine($"Entered Integer value is: {intch} and it's Value converted Character Equivalent is: {charVal}");
            Console.ReadLine();
        }
    }
}