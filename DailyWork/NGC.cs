using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class NGC
    {
        public void ArraayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
           //foreach (var item in arrayList) 
           // {
           //     Console.WriteLine(item);
           // }
           arrayList.Add("AA");
           arrayList.Add(true);
            arrayList.Add(false);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains(10));
            Console.WriteLine(arrayList.IndexOf(20));
        }
        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(10); 
            stack.Push(20);
            stack.Push(30);
            stack.Push("GG");
            stack.Push(true);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item at the peek:"+stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item to be removed:"+stack.Pop());
            Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


        }
        public void QueueHandling()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);  
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(88.87645454);
            foreach (var item in queue)
           {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element at Peek:"+queue.Peek());
            Console.WriteLine("Element to be remove:"+queue.Dequeue());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
      
        }
        public void HtHandling()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);
            ht.Add(3, 30);
            ht.Add("3", "AA");
            ht.Add(4, "BB");
           foreach(var item in ht)
            {
                Console.WriteLine(item);
            }
           ht.Remove(1);
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ht.ContainsKey(6));
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }


        }
        public void SLHandling()
        {
            SortedList sl= new SortedList();
            //In sorted list keys are sorted not the value
            sl.Add(4, 80);
            //sl.Add("5", "cd"); it shows error and do not duplicate the key element
            sl.Add(5, "cd");
            sl.Add(0, 20);
            sl.Add(1, 10);
            sl.Add(2, 20);
            sl.Add(3, 30);
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }
        }
    }
}
