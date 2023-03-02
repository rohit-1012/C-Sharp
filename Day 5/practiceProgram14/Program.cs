namespace practiceProgram14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte cntr = 0, dieVal, val1 = 0, val2 = 0, val3 = 0, val4 = 0, val5 = 0, val6 = 0;
            Random rndm = new Random();
            while(cntr < 100)
            {
                dieVal = Convert.ToByte(rndm.Next(1, 7));
                switch(dieVal)
                {
                    case 1:
                        val1++;
                        break;

                    case 2:
                        val2++;
                        break;

                    case 3:
                        val3++;
                        break;

                    case 4:
                        val4++;
                        break;

                    case 5:
                        val5++;
                        break;

                    case 6:
                        val6++;
                        break;

                    default:
                        break;
                }
                cntr++;
            }
            Console.WriteLine($"Die-roll 1 Count: {val1}, \nDie-roll 2 Count: {val2}, \nDie-roll 3 Count: {val3}, \nDie-roll 4 Count: {val4}, \nDie-roll 5 Count: {val5}, \nDie-roll 6 Count: {val6}");
            Console.ReadLine();
        }
    }
}