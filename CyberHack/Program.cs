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

            bool hacked = false;

            switch (system)
            {
                case SystemType.CorporateServer:
                    hacked =
                        (tools.HasFlag(HackTool.Phishing) || tools.HasFlag(HackTool.Backdoor)) &&
                        (tools.HasFlag(HackTool.BruteForce) || tools.HasFlag(HackTool.ZeroDay));
                    break;

                case SystemType.BankDatabase:
                    hacked =
                        (tools.HasFlag(HackTool.ZeroDay) && tools.HasFlag(HackTool.Backdoor)) ||
                        (tools.HasFlag(HackTool.QuantumExploit) && tools.HasFlag(HackTool.AIOverride));
                    break;

                case SystemType.SmartCityCore:
                    hacked =
                        (tools.HasFlag(HackTool.AIOverride) && tools.HasFlag(HackTool.Backdoor)) ||
                        (tools.HasFlag(HackTool.ZeroDay) && tools.HasFlag(HackTool.BruteForce)) ||
                        (tools.HasFlag(HackTool.QuantumExploit) && tools.HasFlag(HackTool.Phishing));
                    break;

                case SystemType.MilitaryAI:
                    hacked =
                        (tools.HasFlag(HackTool.ZeroDay) && tools.HasFlag(HackTool.AIOverride)) ||
                        ((tools.HasFlag(HackTool.Backdoor) || tools.HasFlag(HackTool.BruteForce)) &&
                        (tools.HasFlag(HackTool.Phishing) || tools.HasFlag(HackTool.QuantumExploit)));
                    break;
                }
        }
    }
}
