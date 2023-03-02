namespace bugBust2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double my_double;
            decimal my_decimal;

            my_double = 3.14;
            my_decimal = 3.14M;

            Console.Write("\nMy Double: {0}", my_double);
            Console.Write("\nMy Decimal: {0}", my_decimal);
            Console.ReadLine();
        }
    }
}