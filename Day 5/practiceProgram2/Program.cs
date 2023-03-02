namespace practiceProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte dieRoll;
            Console.Write("Enter a die-roll value: ");
            dieRoll = Convert.ToByte(Console.ReadLine());

            if(dieRoll == 1)
            {
                Console.WriteLine($"Die-roll value is: {dieRoll}");
            }
            else if (dieRoll == 2)
            {
                Console.WriteLine($"Die-roll value is: {dieRoll}");
            }
            else if (dieRoll == 3)
            {
                Console.WriteLine($"Die-roll value is: {dieRoll}");
            }
            else if (dieRoll == 4)
            {
                Console.WriteLine($"Die-roll value is: {dieRoll}");
            }
            else if (dieRoll == 5)
            {
                Console.WriteLine($"Die-roll value is: {dieRoll}");
            }
            else if (dieRoll == 6)
            {
                Console.WriteLine($"Die-roll value is: {dieRoll}");
            }
            else
            {
                Console.WriteLine("Die-roll value is invalid!");
            }
            Console.ReadLine();
        }
    }
}