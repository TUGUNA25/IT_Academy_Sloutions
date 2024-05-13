using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public static class CollectionsExtensions
    {
        public static int[] TwoToOne(this int[] input, int[] input2) {
            int[] result = new int[input.Length+input2.Length];
            int j = 0;
            for (int i = 0; i < result.Length; i++) {
                j = i;
                if (j < input.Length) {
                    result[i] = input[i];
                }
                else
                {
                    j = i-input.Length;
                    result[i] = input2[j];
                }
             }
            return result;
        }

        public static string StringWithSep(this int[] input, string separator) { 
            StringBuilder sb = new StringBuilder();
            foreach (var item in input)
            {
                sb.Append(item);
            }
            sb.Append(separator);
            return sb.ToString();
        }
    }
}
