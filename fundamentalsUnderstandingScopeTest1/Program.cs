namespace fundamentalsUnderstandingScopeTest1
{
    internal class Program
    {

        private static string k = "helperMethod() Value Verification!";

        static void Main(string[] args)
        {
            helperMethod();
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine($"Outside of for Loop: {j}");
            Console.WriteLine($"Outside of for Loop: {k}");
            helperMethod();
            Console.ReadKey();
        }

        static void helperMethod()
        {
            Console.WriteLine($"Value of k from helperMethod(): {k}");
        }

    }
}