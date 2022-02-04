using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T06._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int divised = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDiv = (x, y) => x % y == 0;

            List<int> result = numbers.Where(x => !isDiv(x, divised)).ToList();


            //List<int> nonDivided = new List<int>();

            //Predicate<int> isDivisible = x => x % divised == 0;
            //Func<List<int>, List<int>> removing = x =>
            //{
            //    foreach (int number in numbers)
            //    {
            //        if (!isDivisible(number))
            //        {
            //            nonDivided.Add(number);
            //        }
            //    }
            //    return nonDivided;
            //};
            //nonDivided = removing(numbers);

            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
