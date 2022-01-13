namespace OO_Labb2
{
    public class ConsoleLogger : IConsoleLogger
    {
        public void Log(string message)
        {
            // Some logging logic
            Console.WriteLine(message);
        }

    }

}