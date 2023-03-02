namespace practiceProgram8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intVal;
            short shortVal;
            Console.Write("Enter an integer value: ");
            intVal = Convert.ToInt32(Console.ReadLine());
            shortVal = Convert.ToInt16((short)intVal);
            Console.WriteLine($"Entered Integer value is: {intVal} and it's Value converted to Short is: {shortVal}");
            Console.ReadLine();
        }
    }
}