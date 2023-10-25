using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class GC
    {
        public void ListHandling()
        {
            List<int> Number = new List<int>();
            Number.Add(10);
            Number.Add(20);
            Number.Add(30);

            foreach (int item in Number)
            {
                Console.WriteLine(item);
            }
            Number.Reverse();
            foreach (int item in Number)
            {
                Console.WriteLine(item);
            }
         
            Console.WriteLine(Number.Contains(10));
            Console.WriteLine(Number.IndexOf(20));

        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
           foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item at the peek:" + stack.Peek());
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item to be removed:" + stack.Pop());
            Console.WriteLine(stack.Pop());
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }


        }
        public void QueueHandling()
        {
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(88.87645454);
            foreach (double item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element at Peek:" + queue.Peek());
            Console.WriteLine("Element to be remove:" + queue.Dequeue());
            foreach (double item in queue)
            {
                Console.WriteLine(item);
            }

        }


    }
}
