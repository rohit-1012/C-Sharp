namespace fundamentalsClassTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car myNewCar = new Car("Maruti", "800", 1980, "Maroon");

            //myCar.Make = "HM";
            myCar.Model = "Contessa";
            myCar.Year = 1989;
            myCar.Color = "Black";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine($"{myOtherCar.Make}, {myOtherCar.Model}, {myOtherCar.Year}, {myOtherCar.Color}");

            myOtherCar.Model = "Premier Padmini";

            Console.WriteLine($"{myCar.Make}, {myCar.Model}, {myCar.Year}, {myCar.Color}");

            Console.WriteLine($"{myNewCar.Make}, {myNewCar.Model}, {myNewCar.Year}, {myNewCar.Color}");

            Console.ReadKey();
        }
    }

    class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }


        public Car()
        {
            Make = "Mahindra";
        }

        public Car(string? make, string? model, int? year, string? color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }

}