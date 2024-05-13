using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public static class StringExtensions
    {
        public static string StringReverse(this string input) {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length-1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

        public static int ElementCounter(this string input, char element) {
            int counter = 0;
            foreach (char c in input)
            {
                if (c == element)  
                    counter++;
            }
            return counter;
        }

        public static bool IfSub(this string input, string sub)
        {
            if (input.Substring(0, sub.Length) == sub) { 
                return true;
            }
            else if(input.Substring(input.Length-sub.Length) == sub)
                return true;

            return false;

        }
    }
}
