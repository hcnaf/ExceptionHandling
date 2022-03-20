using System;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Enter you line: ");
                var str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str))
                    throw new ArgumentException("Your line is empty", nameof(str));

                Console.WriteLine("First character of your line is '" + str[0] + "'");
            }
        }
    }
}