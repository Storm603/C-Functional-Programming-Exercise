using System;
using System.Linq;

namespace T03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minNum = x =>
            {
                int minNum = Int32.MaxValue;

                foreach (int number in x)
                {
                    if (number < minNum)
                    {
                        minNum = number;
                    }
                }

                return minNum;
            };


            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Console.WriteLine(minNum(numbers));

        }
    }
}
