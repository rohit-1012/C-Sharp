namespace practiceProgram5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inpt;
            Console.WriteLine("Enter a number: ");
            inpt = Convert.ToInt16(Console.ReadLine());
            if (inpt>65)
            {
                Console.WriteLine("Number is greater than 65!");
            }
            Console.ReadLine();
        }
    }
}