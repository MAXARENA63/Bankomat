using System;

namespace BankWork
{
    public static class CLI
    {
        public static string Input(string message)
        {
            Console.Write(message);
            var temp = Console.ReadLine();
            return temp;
        }

        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintInfo(string message)
        {
            Print(message, ConsoleColor.Blue);
        }

        public static void PrintError(string message)
        {
            Print(message, ConsoleColor.Red);
        }

        public static void PrintWarning(string message)
        {
            Print(message, ConsoleColor.Yellow);
        }

        public static void PrintSuccess(string message)
        {
            Print(message, ConsoleColor.Green);
        }
    }
}