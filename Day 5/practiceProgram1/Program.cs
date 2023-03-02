namespace practiceProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char gender;
            Console.Write("Enter a gender character: ");
            gender = Convert.ToChar(Console.ReadLine());
            if (gender == 'M' || gender == 'F')
            {
                Console.WriteLine("Entered Gender is valid!");
            }
            else
            {
                Console.WriteLine("Entered gender is invalid!");
            }
            Console.ReadLine();
        }
    }
}