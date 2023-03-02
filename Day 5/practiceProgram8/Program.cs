namespace practiceProgram8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char fileType;
            Console.WriteLine("Enter a file-type: ");
            fileType = Convert.ToChar(Console.ReadLine());
            switch(fileType)
            {
                case 's':
                    Console.WriteLine("The filer is single");
                    break;

                case 'm':
                    Console.WriteLine("The filer is married filing at the single rate");
                    break ;

                case 'j':
                    Console.WriteLine("The filer is married filing at the joint rate");
                    break;

                default:
                    Console.WriteLine("Invalid File-type, Kindly re-check your input.");
                    break;
            }
            Console.ReadLine();
        }
    }
}