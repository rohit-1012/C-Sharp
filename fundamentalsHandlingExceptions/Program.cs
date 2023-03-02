namespace fundamentalsHandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"D:\Rohit Stuff\Rohit Stuff\C# Practice\testTextFile.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("An Error Occured: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Kindly check the name of the File specified!");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("An Error Occured: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Kindly check the name of the Directory specified!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured: ");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}