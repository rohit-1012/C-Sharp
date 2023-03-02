namespace fundamentalsWorkingWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>() { 
                new Car() { Make = "Tata", Model = "Harrier", VIN = "A1", Price = 1200000, Year = 2018 },
                new Car() { Make = "Mahindra", Model = "Thar", VIN = "A2", Price = 1500000, Year = 2017 },
                new Car() { Make = "Maruti", Model = "Omni", VIN = "A3", Price = 700000, Year = 1994},
                new Car() {Make = "Hindustan Motors", Model = "Padmini Premier", VIN = "A4", Price = 900000, Year = 1985},
                new Car() {Make = "Hindustan Motors", Model = "Contessa", VIN = "A5", Price = 1000000, Year = 1974},
                new Car() {Make = "Mahindra", Model = "Scorpio NX", VIN = "A6", Price = 2000000, Year = 2021},
                new Car() {Make = "Hindustan Motors", Model = "Ambassador", VIN = "A7", Price = 1200000, Year = 1970}
            };

            //LINQ Query Syntax
            /*
            var hm = from cars in myList
                       where cars.Make == "Hindustan Motors"
                       && cars.Year == 1970
                       select cars;
            */
            /*
            var orderedCars = from cars in myList
                              orderby cars.Year descending
                              select cars;
            */

            //LINQ Method Syntax
            //var mahindra = myList.Where(p => p.Make == "Mahindra" && p.Year == 2017);
            //var orderedCars = myList.OrderByDescending(p => p.Year);

            //var orderedCars = myList.OrderByDescending(p => p.Year).First(p => p.Make == "Mahindra");
            //Console.WriteLine(myList.TrueForAll(p => p.Year < 2022));

            //myList.ForEach(p => p.Price= p.Price - 30000);
            //myList.ForEach(p => Console.WriteLine($"{p.Make}, {p.Year}, {p.Price:C}"));

            //Console.WriteLine(myList.Exists(p => p.Model == "Thar"));

            //Console.WriteLine(myList.Sum(p => p.Price));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine($"{car.Year}, {car.Model}, {car.VIN}");
            }
            */

            var newCars = from cars in myList
                     where cars.Make == "Hindustan Motors"
                     && cars.Year == 1970
                     select new { cars.Make, cars.Model };
            Console.WriteLine(newCars.GetType());



            Console.ReadKey();
        }
    }

    class Car
    {
        public string Model { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }

}