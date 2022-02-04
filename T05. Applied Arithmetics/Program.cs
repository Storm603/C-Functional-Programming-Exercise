using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace T05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string action = Console.ReadLine();

            Action<int[]> addFunc = x =>
            {
                for (int i = 0; i < x.Length; i++)
                    x[i]++;
            };

            Action<int[]> multFunc = x =>
            {
                for (int i = 0; i < x.Length; i++)
                    x[i]*=2;
            };

            Action<int[]> subtractFunc = x =>
            {
                for (int i = 0; i < x.Length; i++)
                    x[i]--;
            };

            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            while (action != "end")
            {
                switch (action)
                {
                    case "add":
                        addFunc(nums);
                        break;
                    case "multiply":
                        multFunc(nums);
                        break;
                    case "subtract":
                        subtractFunc(nums);
                        break;
                    case "print":
                        print(nums);
                        break;
                }

                action = Console.ReadLine();
            }
        }
    }
}
