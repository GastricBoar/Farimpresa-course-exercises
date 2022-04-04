using System;

namespace FindMinMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            float[] data = new float[5];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = randomNum.Next(1000);
            }

            float min = data[0];
            float max = data[0];

            Console.WriteLine("Your random generated array is:\n");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            FindMinMax(data, ref min, ref max);
            
            Console.WriteLine("\nIl valore min trovato è " + min);
            Console.WriteLine("Il valore max trovato è " + max);
        }

        private static void FindMinMax(float[] data, ref float min, ref float max)
        {  

            for (int i = 1; i < data.Length; i++) //loop cycles through data array, setting min and max values to data[0] allows to skip first cycle.
            {

                if (data[i] > max) //Compare data[0] with data[1], then if thisNum > max, max becomes new max, while min remains the smallest value.
                {
                    max = data[i];
                }
                else if (data[i] < min)
                {
                    min = data[i];
                }
            }

        }


    }
}
