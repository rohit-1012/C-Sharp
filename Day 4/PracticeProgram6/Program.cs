namespace PracticeProgram6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charVal;
            Console.WriteLine("Enter a character: ");
            charVal = Convert.ToChar(Console.ReadLine());
            if (charVal == 't' || charVal == 'T')
            {
                if (charVal == 't')
                {
                    Console.WriteLine("Character entered is 't'");
                }
                if (charVal == 'T')
                {
                    Console.WriteLine("Character entered is 'T'");
                }
            }
            if (charVal != 't' && charVal != 'T')
            {
                Console.WriteLine($"Character entered is {charVal}");
            }

            Console.ReadLine();
        }
    }
}