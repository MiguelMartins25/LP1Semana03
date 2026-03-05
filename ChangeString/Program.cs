using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please input a phrase:");
            string fullstring = Console.ReadLine();
            Console.Write("Input a letter:");
            string letter = Console.ReadLine();
            char charletter = char.Parse(letter);
            foreach (char i in fullstring)
            {
                if (i == charletter)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
    }
}
