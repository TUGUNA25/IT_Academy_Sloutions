using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public static class IntExtensions
    {

        public static void OddOrEven(this int input) { 
            if (input % 2==0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");
        }

        public static int AbsoliteValue(this int input) { 
            if (input < 0)
                input = input * -1;
            return input;
        }

        public static int RoundWithMultiple(this int input, int num)
        {
            int dif = input / num;
            int case1 = input - (dif * num);
            int case2 = Math.Abs(input - ((dif + 1) * num));
            if (case1 < case2)
                return dif*num;
            else 
                return (dif+1)*num;


        }


    }
}
