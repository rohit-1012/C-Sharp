namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opdisp;
            Program program = new Program();
            opdisp = program.calcSoln();
            Console.WriteLine($"The calculated value is: {opdisp}");
            Console.ReadLine();
        }

        public int calcSoln()
        {
            int var1, var2, varcalc = 0;
            Console.WriteLine("Enter value 1: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value 2: ");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a function from +,-,/,*,%");
            String strfunc = Console.ReadLine();
            if (strfunc == "+")
            {
                varcalc = var1 + var2;
            }
            if (strfunc == "-")
            {
                varcalc = var1 - var2;
            }
            if (strfunc == "/")
            {
                varcalc = var1 / var2;
            }
            if (strfunc == "%")
            {
                varcalc = var1 % var2;
            }
            if (strfunc == "*")
            {
                varcalc = var1 * var2;
            }

            return varcalc;
        }
    }
}