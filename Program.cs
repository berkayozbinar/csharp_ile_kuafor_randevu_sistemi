using System;

namespace nesneproje
{
    class Program
    {
        public static void Main()
        {
            bool loop1 = true;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Title = "KUAFOR";

            MainMenu.Menu(loop1);
        }
    }
}