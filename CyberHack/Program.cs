using System;

namespace CyberHack
{
    [Flags]
    enum HackTool
    {
        None = 0,
        BruteForce = 1,
        Phishing = 2,
        Backdoor = 4,
        ZeroDay = 8,
        AIOverride = 16,
        QuantumExploit = 32
    }

    enum SystemType
    {
        CorporateServer,
        BankDatabase,
        SmartCityCore,
        MilitaryAI
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            // Codigo para ler qual o SystemType a hackear
            SystemType system = Enum.Parse<SystemType>(Console.ReadLine());
            // Codigo que divide cada HackingTool e adiciona-as a um array
            string[] HackingTool = Console.ReadLine().Split(" ");

            HackTool tools = HackTool.None;
            
            // Foreach para transformar cada HackingTool em uma variável
            foreach (string t in HackingTool)
            {
                tools |= Enum.Parse<HackTool>(t);
            }

        }
    }
}
