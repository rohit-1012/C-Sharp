namespace practiceProgram7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long myLong;
            short myShort;

            myLong = 23;
            myShort = Convert.ToInt16((short)myLong);
            Console.WriteLine(myShort);
            Console.ReadLine();
        }
    }
}