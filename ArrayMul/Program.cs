using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            //input given on the console
            float[,] A = new float [2,2];
            float[] B = new float [2];

            A[0,0] = float.Parse(args[0]);
            A[0,1] = float.Parse(args[1]);
            A[1,0] = float.Parse(args[2]);
            A[1,1] = float.Parse(args[3]);

            B[0] = float.Parse(args[4]);
            B[1] = float.Parse(args[5]);

            //for every number that = 0 or is smaller than 2, add ++
            //so code runs till the number desired is 2, making sure it runs twice
            //and always gives two "WriteLine"s at the end 
              for (int i = 0; i < 2; i++)
            {
                //make a result that later adds to it
                float result = 0;
                for (int j = 0; j < 2; j++)
                {
                    //adds to the float result of the multiplication of "matrizes"
                    result += A[i,j]*B[j];
                }
                //resultado alinhado à direita por 7 posições e com duas casas decimais 
                Console.WriteLine($"| {result,7:f2} |");
            }
        }
    }
}
