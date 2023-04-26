using System;

namespace nesneproje
{
    class Exit
    {
        public static void ExitFromProgram()
        {
            Console.Clear();
            Console.WriteLine("\nİyi günler.\n");
            Environment.Exit(0);
        }
    }
}
