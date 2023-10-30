using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class GenericExample<T>
    {

        private T[] Arr;

        public GenericExample(T[] arr)
        {
            Arr1 = arr;
        }

        public T[] Arr1 { get => Arr; set => Arr = value; }

        public void Display()
        {
            foreach (var item in Arr) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
