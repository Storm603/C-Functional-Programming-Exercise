using System;

namespace T02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = x => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", x));

            string[] input = Console.ReadLine().Split();

            print(input);
        }
    }
}
