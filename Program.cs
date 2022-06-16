using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, counter));
        }
        static string RepeatString (string input, int counter)
        {
            string result = string.Empty;

            for(int i = 0; i < counter; i++)
            {
                result = result + input;
            }

            return result; 
        }
    }
}
