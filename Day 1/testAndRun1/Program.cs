namespace testAndRun1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("You need to include a filename.");
            }
            else
            {
                // declare objects for connecting to files...
                StreamReader InFile = null;
                StreamWriter OutFile = null;
                try
                {
                    // Open file name included on command line...
                    InFile = File.OpenText(args[0]);
                    // Create the output file...
                    OutFile = File.CreateText("outfile.txt");
                    Console.WriteLine("Numbering...");
                    // Read first line of the file...
                    string line = InFile.ReadLine();
                    int ctr = 1;
                    // loop through the file as long as not at the end...
                    while (line != null)
                    {
                        OutFile.WriteLine($"{ctr.ToString().PadLeft(3,'0')}: {line}");
                        Console.Write($"..{ctr.ToString()}..");
                        ctr++;
                        line = InFile.ReadLine();
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine($"Could not find the file {args[0]}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                finally
                {
                    if (InFile != null)
                    {
                        // Close the files
                        InFile.Close();
                        OutFile.Close();
                        Console.WriteLine("...Done.");
                    }
                }
            }
            Console.ReadLine();
        }
        
    }
}