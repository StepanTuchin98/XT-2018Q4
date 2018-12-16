using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5.ToIntOrNotToInt
{
    public static class StringHelper
    {
        public static bool IsPositiveInt(this string str)
        {
            var pattern = new Regex(@"(\d*\,|\.*\d+E[+,-]\d+)|(\d*\,|\.*\d+)");
            return pattern.IsMatch(str) & pattern.Replace(str, String.Empty) == String.Empty;
        }
    }
}
