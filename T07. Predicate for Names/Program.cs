using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> filtering = (x, y) => x.Length <= y;

            List<string> filtered = names.Where(x => filtering(x, nameLength)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, filtered));
        }
    }
}
