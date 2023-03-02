namespace practiceProgram3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            char sex = 'f';
            Console.WriteLine($"Starting tests: Day:{day}, Sex:{sex}");

            if(day >= 1 && day <= 7)
            {
                Console.WriteLine("Day is from 1 to 7");
            }
            if (sex == 'm' || sex == 'f')
            {
                Console.WriteLine("Sex is Male or Female");
            }
            Console.WriteLine("Done with the checks.");
            Console.ReadLine();
        }
    }
}