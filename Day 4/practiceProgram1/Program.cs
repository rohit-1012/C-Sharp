namespace practiceProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesOfPie = 0;
            double piecesForMe = 0;

            piecesOfPie = 3 * 6;
            piecesForMe = piecesOfPie % 13;

            Console.WriteLine($"Pieces of Pie: {piecesOfPie}");
            Console.WriteLine($"Pieces For Me: {piecesForMe}");
            Console.ReadLine();
        }
    }
}