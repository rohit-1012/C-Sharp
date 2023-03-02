namespace fundamentalsEventDrivenProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Timers.Timer mytimer = new System.Timers.Timer(2000);
            mytimer.Elapsed += Mytimer_Elapsed;
            mytimer.Start();
            Console.ReadKey();

        }

        private static void Mytimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"Elapsed: {e.SignalTime:HH:mm:ss.fff}");
        }
    }
}