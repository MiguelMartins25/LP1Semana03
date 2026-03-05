using System.Globalization;
using System;
using System.IO.Pipelines;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            // Relacionar cada arg necessario a um float
            float arg1 = float.Parse(args[0]);
            float arg2 = float.Parse(args[1]);
            float arg3 = float.Parse(args[2]);
            float arg4 = float.Parse(args[3]);
            float arg5 = float.Parse(args[4]);
            float arg6 = float.Parse(args[5]);

            // Criação dos Arrays necessários, A é um array multidimencional e o b é um array normal
            float [,] A =
            {
                { arg1, arg2 },
                { arg3, arg4 }
            };

            float [] b = new float[] {arg5, arg6};

            // Array que guardará os resultados
            float[] result = new float[2];

            // Usar os 2 loops para realizar os cálculos
            for (int i = 0; i < 2; i++)
            {
                result[i] = 0;

                for(int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }
            // Print do resultado no formato desejado
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {result[i],7:F2} |");
            }
        }
    }
}
