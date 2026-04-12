

namespace ServiceLayer.Helpers
{
    public class Helper
    {
        public static void PrintConsole(ConsoleColor color, string text)
        {

            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }   
}
