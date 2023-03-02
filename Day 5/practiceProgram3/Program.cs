namespace practiceProgram3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte dieRoll;
            Console.Write("Press ENTER to roll die: ");
            Console.ReadLine();
            Random rndm = new Random();
            dieRoll = (byte)rndm.Next(0, 10);
            switch(dieRoll)
            {
                case 1:
                    Console.WriteLine($"Die-roll value is: {dieRoll}");
                    break;
                
                case 2:
                    Console.WriteLine($"Die-roll value is: {dieRoll}");
                    break;

                case 3:
                    Console.WriteLine($"Die-roll value is: {dieRoll}");
                    break;

                case 4:
                    Console.WriteLine($"Die-roll value is: {dieRoll}");
                    break;

                case 5:
                    Console.WriteLine($"Die-roll value is: {dieRoll}");
                    break;

                case 6:
                    Console.WriteLine($"Die-roll value is: {dieRoll}");
                    break;

                default:
                    Console.WriteLine($"Entered die-roll value {dieRoll} is invalid!");
                    break;
            }
            Console.ReadLine();
        }
    }
}