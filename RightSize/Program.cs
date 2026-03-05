using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach(string i in args)
            {
                // Counts the number of letters in each string
                int stringlength = i.Length;

                // Sees if the number of letters in the string is above 3
                if (stringlength <= 3)
                {
                    continue;
                }

                // Print the string
                Console.WriteLine(i);
            }
        }
    }
}
