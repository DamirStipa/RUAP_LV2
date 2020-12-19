using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Utilities
    {
        public static List<int> Filter (IEnumerable<int> sequence, Func<int, bool> mechanism)
        {
            var list = new List<int>();
            foreach (var number in sequence)
            {
                if (mechanism(number))
                    list.Add(number);
            }

            return list;
        }
    }
}
