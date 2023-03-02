namespace secondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius = 4;
            const double pi = 3.14;
            double area, circum;

            area = pi * radius * radius;
            circum = 2 * pi * radius;

            Console.WriteLine($"Radius = {radius}, Pi = {pi}");
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Circumference = {circum}");
            Console.ReadLine();
        }
    }
}