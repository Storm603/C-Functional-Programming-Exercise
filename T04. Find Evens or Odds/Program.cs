using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string condition = Console.ReadLine();

            List<int> nums = new List<int>();

            for (int i = input[0]; i <= input[1]; i++)
            {
                nums.Add(i);
            }

            Predicate<int> filterEven = x => x % 2 == 0;
            Predicate<int> filterOdd = x => x % 2 != 0;

            List<int> filtered = condition == "even" ? nums.FindAll(filterEven) : nums.FindAll(filterOdd);

            Console.WriteLine(string.Join(" ", filtered));
        }
    }
}
