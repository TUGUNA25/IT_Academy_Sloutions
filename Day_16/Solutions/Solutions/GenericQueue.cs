using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class GenericQueue<T>
    {
        private T[] arr;
        

        public GenericQueue()
        {
            
            arr = new T[0];
        }

        public void Enqueue(T element) {
            T[] test_arr = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                test_arr[i] = arr[i];
            }
            test_arr[test_arr.Length - 1] = element;
            arr = test_arr;
            Console.WriteLine($"Element {element} Enqueue Successfully");

        }
        public void Peek() { 
            if (arr.Length == 0)
                Console.WriteLine("Queue Is Empty");    
            else
            {
                Console.WriteLine($"{arr[0]}");
            }

        }

        public void Dequeue() {
            if (arr.Length == 0)
            {
                Console.WriteLine("Queue Is Empty");
            }
            else {
                T answer = arr[0];
                T[] test_arr = new T[arr.Length - 1];
                for (int i = 1; i < arr.Length; i++)
                {
                    test_arr[i - 1] = arr[i];
                }
                arr = test_arr;
                Console.WriteLine($"Dequeue element {answer}");
            }

        }
    }
}
