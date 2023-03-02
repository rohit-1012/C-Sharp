namespace practiceProgram4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1;
            double x2;
            string str;
            char ch;
            float x3;
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
            str = Convert.ToString(x1);
            Console.WriteLine($"Integer as String: {str}");
            x1 = Convert.ToInt16(x2);
            Console.WriteLine($"Double as Integer: {x1}");
            Console.ReadLine();

        }
    }
}