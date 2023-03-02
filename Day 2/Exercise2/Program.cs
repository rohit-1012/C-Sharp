namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctr;
            char ch;

            Console.WriteLine("\nNumber Value\n");

            for (ctr = 97; ctr <= 122; ctr++)
            {
                ch = (char)ctr;
                Console.WriteLine("{0} is {1}", ctr, ch);
            }
            Console.ReadLine();
        }
    }
}