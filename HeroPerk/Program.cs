using System;

namespace HeroPerk
{
    [Flags]
enum Perks
{
    None = 0, // 0000
    WarpShift = 1, //0001
    Stealth = 2, // 0010
    AutoHeal = 4, // 0100
    DoubleJump = 8 // 1000
}
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks perks = Perks.None;

            foreach (char c in args[0])
            {
                switch (c)
                {
                    // Usando XOR para dizer se o perk foi obtido ou não
                    case 'W': perks ^= Perks.WarpShift; break;
                    case 'S': perks ^= Perks.Stealth; break;
                    case 'A': perks ^= Perks.AutoHeal; break;
                    case 'D': perks ^= Perks.DoubleJump; break;
                    default:
                        Console.WriteLine("!Unknown perk!"); // Quando é usado uma letra desconhecida
                        return;
                }
            }

            if (perks == Perks.None) // não foi escrito nada
            {
                Console.WriteLine("!No perks at all!");
            }
            else
            {
                Console.WriteLine(perks);
            }
            // Para verificar se o jogador obteu ambos stealth e doublejump
            if ((perks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }
            // Caso o jogador não obtenha o perk de Autoheal
            if (!perks.HasFlag(Perks.AutoHeal))
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}
