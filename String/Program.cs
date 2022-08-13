namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strvar = "   This is my temporary string variable       ";
            Console.WriteLine($"#{strvar.ToUpper()}#");
            Console.WriteLine($"#{strvar.ToLower()}#");
            Console.WriteLine($"#{strvar.TrimEnd()}#");
            Console.WriteLine($"#{strvar.TrimStart()}#");
            Console.WriteLine($"#{strvar.Trim()}#");
            Console.WriteLine(strvar.Replace("my" , "our"));
            Console.WriteLine(strvar.Contains("temporary"));
            Console.WriteLine(strvar.Contains("permanent"));
            Console.WriteLine(strvar);
            Console.ReadLine();
        }
    }
}