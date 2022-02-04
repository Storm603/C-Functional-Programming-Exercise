using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace T09_Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> people = Console.ReadLine().Split().ToList();

            string action = Console.ReadLine();
            while (action != "Party!")
            {
                string[] items = action.Split();

                string method = items[0];
                string operation = items[1];
                string value = items[2];

                if (method == "Double")
                {
                    List<string> doubleNames = people.FindAll(GetPredicate(operation, value));

                    if (!doubleNames.Any())
                    {
                        action = Console.ReadLine();
                        continue;
                        
                    }

                    int index = people.FindIndex(GetPredicate(operation, value));
                    people.InsertRange(index, doubleNames);
                }
                else
                {
                    people.RemoveAll(GetPredicate(operation, value));
                }

                action = Console.ReadLine();
            }


            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static Predicate<string> GetPredicate(string operation, string value)
        {
            if (operation == "StartsWith")
            {
                return x => x.StartsWith(value);
            }

            if (operation == "EndsWith")
            {
                return x => x.EndsWith(value);
            }

            int valueAsInt = int.Parse(value);

            return x => x.Length == valueAsInt;
        }
    }
}
