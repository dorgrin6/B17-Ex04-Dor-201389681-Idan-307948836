using System;

namespace Ex04.Menus.Test
{
    public static class Actions
    {
        public static void DisplayVersion()
        {
            Console.WriteLine("App Version: 17.2.4.0");
        }

        public static void CountSpaces()
        {
            int result;

            result = getUserInput().Split(' ').Length - 1;
            Console.WriteLine("Your sentence have {0} times the char '{1}'.", result, ' ');
        }

        public static void CharsCount()
        {
            int result;

            result = getUserInput().Length;
            Console.WriteLine("Your sentence have {0} chars.", result);
        }

        private static string getUserInput()
        {
            string input;

            Console.WriteLine("Please enter a sentence:");
            input = Console.ReadLine();
            return input;
        }

        public static void ShowTime()
        {
            DateTime time = DateTime.Now;

            Console.WriteLine("The time now is: {0}:{1}:{2}", time.Hour, time.Minute, time.Second);
        }

        public static void ShowDate()
        {
            DateTime time = DateTime.Now;

            Console.WriteLine("The date today is: {0}/{1}/{2}", time.Day, time.Month, time.Year);
        }
    }
}
