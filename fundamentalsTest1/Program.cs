namespace fundamentalsTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Hello World Program
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            */

            /*
            Variables
            int x, y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadKey();
            Console.Write("Type your First Name: ");
            string firstName;
            firstName = Console.ReadLine();
            Console.Write("Type your Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hello {firstName} {lastName}!");
            Console.ReadKey();
            */

            /*
            "if", "if-else", and "if-else-if" Statement
            Console.WriteLine("Rohit's Big Giveaway!");
            Console.Write("Choose a Door Number: 1, 2, or 3 : ");
            int doorNumber = Convert.ToInt16(Console.ReadLine());
            if (doorNumber == 1)
            {
                Console.WriteLine("You won a car!");
            }
            else if (doorNumber == 2)
            {
                Console.WriteLine("You won a Holiday!");
            }
            else if (doorNumber == 3)
            {
                Console.WriteLine("You won $10,00,000!");
            }
            else
            {
                Console.WriteLine("Incorrect Selection! \nPlease enter a valid door number.");
            }
            Console.ReadKey();
            */

            /*
            Iteration Looping using "for"
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found Number 7");
                }
            }
            Console.ReadKey();
            */

            /*
            Arrays
            int[] numArray = new int[5];
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;
            Console.WriteLine(numArray[3]);
            int[] numArray2 = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int j = 0; j < numArray2.Length; j++)
            {
                Console.WriteLine(numArray2[j]);
            }
            string[] stringArr = new string[] { "This", "is", "a", "String", "Array" };
            for (int k = 0; k < stringArr.Length; k++)
            {
                Console.Write($"{stringArr[k]} ");
            }
            string testString = "This is a test string for string-to-charArray conversion test!";
            char[] revArray = testString.ToCharArray();
            foreach (char arrayVal in revArray.Reverse())
            {
                Console.Write(arrayVal);
            }
            Console.ReadKey();
            */

            //Methods and their use
            helloWorld();
            Console.ReadKey();

        }

        private static void helloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}