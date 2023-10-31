using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class DelegateExample
    {
        private int num1, num2;

        //public DelegateExample(int num1, int num2)
        //{
        //    this.num1 = num1;
        //    this.num2 = num2;
        //}

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        public static void MethodA( string message)
        {
            Console.WriteLine("Hello World!!!!!!!!!!!!!!!!!");
            Console.WriteLine(message);
        }
        public void Add(int num1,int num2) 
        {
            Num1=num1;
            Num2=Num2;
            Console.WriteLine(Num1 + Num2);
        }
        public int AddR(int num1, int num2) 
        {
            Num1 = num1;
            Num2 = num2;
            return Num1 + Num2;
        }


    }
}
