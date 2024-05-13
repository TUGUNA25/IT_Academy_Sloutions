using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public static class ArrayExtensions
    {
        public static int[] NoDuplicate(this int[] array)
        {
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        foundDup = true;
                        numDups++; 
                        break;
                    }
                }

                if (foundDup == false)
                {
                    array[prevIndex] = array[i];
                    prevIndex++;
                }
            }

            for (int k = 1; k <= numDups; k++)
            {
                array[array.Length - k] = '\0';
            }

            int uniquecounter = 0;
            foreach (var item in array)
            {
                if (item != 0)
                    uniquecounter++;
            }
            int[] answer = new int[uniquecounter];
            for (int i = 0; i < uniquecounter; i++)
            {
                answer[i] = array[i];
            }

            return answer;

            
        }

        public static bool Contains(this int[] input,int element) {
            int counter = 0;
            foreach (int item in input)
            {
                if(item == element)
                    counter++;
            }
            if (counter !=  0)
                return true;
            else
                return false;
        }

        public static int MaxValue(this int[] input) { 
            int maxvalue = input[1];
            foreach (int item in input)
            {
                if(item> maxvalue)
                    maxvalue = item;
            }
            return maxvalue;
        }
    }
}
