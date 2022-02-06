using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace T11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();


            //Func<string[], int, string> filtering = (x, y) =>
            //{
            //    foreach (string name in x)
            //    {
            //        if (y(name))
            //        {
                        
            //        }
            //    }
            //};
            

            Func<string, int, bool> countingChars = (x, y) =>
            {
                int sumOfChars = 0;

                foreach (char letter in x)
                {
                    sumOfChars += letter;
                }

                if (sumOfChars >= y)
                {
                    return true;
                }

                return false;
            };

            Func<string[], Func<string, int, bool>, string> filter = (name, sum) =>
            {

                foreach (string names in name)
                {
                    if (sum(names, num))
                    {
                        return names;
                    }
                }

                return null;
            };
            Console.WriteLine(filter(names, countingChars));
            
        }
    }
}
