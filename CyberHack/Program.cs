using System;

namespace CyberHack
{
    [Flags]
    enum HackTool
    {
        BruteForce = 0,
        Phishing = 1,
        Backdoor = 2,
        ZeroDay = 4,
        AIOverride = 8,
        QuantumExploit = 9
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
        }
    }
}
