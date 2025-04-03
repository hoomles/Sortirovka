using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class Sortings
    {
        private static List<int> ParseString(string s) // строку в список
        {
            if (s == null)
            {
                return new List<int>();
            }

            return s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
        }
    }
}
