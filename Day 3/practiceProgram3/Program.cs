namespace practiceProgram3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, sox1, soch;
            double x2, sox2;
            string str;
            char ch;
            float x3, sox3;
            sox1 = sizeof(int);
            sox2 = sizeof(double);
            sox3 = sizeof(float);
            soch = sizeof(char);
            Console.WriteLine($"Size of Integer: {sox1}, \nSize of Float: {sox3}, \nSize of Double: {sox2}, \nSize of Char: {soch}");
            Console.WriteLine("Enter an Integer Value: ");
            x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter two Floating point Integer Values: ");
            Console.Write("Float: ");
            x3 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Double: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Character Value: ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a String: ");
            str = Console.ReadLine();
            Console.WriteLine($"Value of x1: {x1}, \nValue of x2: {x2}, \nValue of x3: {x3}, \nValue of ch: {ch}, \nString Entered: {str}");
            Console.ReadLine();

        }
    }
}