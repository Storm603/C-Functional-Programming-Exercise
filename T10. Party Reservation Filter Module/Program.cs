using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();
                List<string> names = Console.ReadLine().Split().ToList();

            string action = Console.ReadLine();

            while (action != "Print")
            {
                string[] split = action.Split(";", StringSplitOptions.RemoveEmptyEntries);

                
                if (split[0] == "Add filter")
                {
                    predicates.Add(split[1] + split[2], AddFilter(split[1], split[2]));
                }
                else if (split[0] == "Remove filter")
                {
                    predicates.Remove(split[1] + split[2]);
                }
                action = Console.ReadLine();
            }

            List<string> leftovers = new List<string>();

            foreach (var (key, value) in predicates)
            {
                names.RemoveAll(value);
            }

            Console.WriteLine(string.Join(" ", names));
        }

        //public List<Predicate<string>> RemoveFilter(List<Predicate<string>>, )
        //{

        //}

        public static Predicate<string> AddFilter(string action ,string value)
        {

            if (action == "Starts with")
            {
                return x => x.StartsWith(value);
            }

            if (action == "Ends with")
            {
                return x => x.EndsWith(value);
            }

            if (action == "Length")
            {
                return x => x.Length == int.Parse(value);
            }

            return x => x.Contains(value);
            
        }
    }
}
