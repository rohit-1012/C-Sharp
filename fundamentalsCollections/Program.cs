using System.Collections;

namespace fundamentalsCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Initializer Syntax
            /*
            Car car1 = new Car() { Make = "Tata", Model = "Harrier", VIN = "A1" };
            Car car2 = new Car() { Make = "Mahindra", Model = "Thar", VIN = "A2" };
            Book book1 = new Book() { Author = "George R.R. Martin", Title = "Game of Thrones", ISBN = "0-000-000000-0" };
            */ 

            //ArrayLists (Deprecated)
            /*
            ArrayList myArray = new ArrayList();
            myArray.Add(car1);
            myArray.Add(car2);
            myArray.Add(book1);
            myArray.Remove(book1);

            foreach (Car car in myArray)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            //Lists<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine($"{car.Make}, {car.Model}");
            }
            */

            /*
            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine($"{myDictionary["A1"].Make}");
            */

            //Collections Initializer Syntax
            List<Car> myList = new List<Car>() { new Car() { Make = "Tata", Model = "Harrier", VIN = "A1" }, new Car() { Make = "Mahindra", Model = "Thar", VIN = "A2" } 
            };

            Console.ReadKey();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}