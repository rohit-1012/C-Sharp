namespace practiceProgram13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ipName;
            char nameVal = 'x';
            Console.Write("Enter Name: ");
            ipName = Console.ReadLine();

            if(ipName == "Richard")
            {
                nameVal = 'a';
            }
            else if (ipName == "Barbara")
            {
                nameVal = 'b';
            }
            else if (ipName == "Kaylee")
            {
                nameVal = 'c';
            }
            else if (ipName == "Robert")
            {
                nameVal = 'd';
            }
            switch (nameVal)
            {
                case 'a':
                    Console.WriteLine("Hello Rich!");
                    break;

                case 'b':
                    Console.WriteLine("Hello Barb!");
                    break;

                case 'c':
                    Console.WriteLine("Hello Kaylee!");
                    break;

                case 'd':
                    Console.WriteLine("Hello Bob!");
                    break;

                default:
                    Console.WriteLine($"Hello {ipName}!");
                    break;
            }
            Console.ReadLine();
        }
    }
}