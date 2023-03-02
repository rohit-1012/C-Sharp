namespace fundamentalsClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine("Enter Car Make, Model, Year, and Color: ");
            Console.Write("Make:");
            myCar.make = Console.ReadLine();
            Console.Write("Model:");
            myCar.model = Console.ReadLine();
            Console.Write("Year:");
            myCar.year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Color:");
            myCar.color = Console.ReadLine();

            Console.WriteLine($"{myCar.make}, {myCar.model}, {myCar.year}, {myCar.color}");

            decimal value = marketValue(myCar);
            Console.WriteLine($"{value:C}");
            Console.ReadKey();
        }

        private static decimal marketValue(Car car)
        {
            decimal carValue;
            if (car.year < 2017)
            {
                carValue = 700000.00M;
            }
            else
            {
                carValue = 1000000.00M;
            }
            return carValue;
        }

    }

    class Car
    {
        public string make { get; set; }
        public string  model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
    }

}