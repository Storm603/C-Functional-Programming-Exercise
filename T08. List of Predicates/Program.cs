using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T08._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, number).ToList();

            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (int divider in dividers)
            {
                predicates.Add(x => x % divider == 0);
            }

            foreach (int num in numbers)
            {
                bool isDiv = true;

                foreach (Predicate<int> predicate in predicates)
                {
                    if (!predicate(num))
                    {
                        isDiv = false;
                        break;
                    }
                }

                if (isDiv)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
