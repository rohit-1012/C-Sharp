namespace constantsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int val1 = 12, val2 = 34;
            const double val3 = 3.4452, val4 = 402.7;
            int addVal = 0, subVal = 0, multVal = 0;
            double divideVal = 0, modVal = 0;

            addVal = val1 + val2;
            subVal = val1 - val2;
            multVal = val1 * val2;
            divideVal = val3 / val4;
            modVal = val4 % val3;

            Console.WriteLine($"Addition: {addVal}, \nSubtraction: {subVal}, \nMultiplication: {multVal}, \nDivision: {divideVal}, \nModulus: {modVal}\n");
            Console.ReadLine();
        }
    }
}