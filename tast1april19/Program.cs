using System;

namespace tast1april19
{
    internal class Program
    {
        static void Main(string[] args)
        {







            int[] numbers = { 1, 55, 190, 100 };
            int maxNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }

            }
            Console.WriteLine(maxNumber);




















        }
    }
}
