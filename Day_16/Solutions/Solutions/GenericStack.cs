using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class GenericStack<T>
    {
        private T[] arr;

        public GenericStack()
        {   
            
            arr = new T[0];
        }

        public void Push(T element)
        {
            T[] test_arr = new T[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                test_arr[i] = arr[i];
            }
            test_arr[test_arr.Length-1] = element;
            arr  =test_arr;
            Console.WriteLine($"Element {element} Push Successfully");
        }

        public void Peek() {
            if (arr.Length == 0)
                Console.WriteLine("Stack Is Empty!!!!!");
            else
                Console.WriteLine($"{arr[arr.Length-1]}");
        }

        public void Pop()
        {
            if (arr.Length == 0)
                Console.WriteLine("Stack Is Empty!!!!!");
            else
            {
                T answer = arr[arr.Length - 1];
                T[] test_arr = new T[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    test_arr[i] = arr[i];
                }
                arr = test_arr;
                Console.WriteLine($"Pop element {answer}");
            }
            
        }

    }
}
