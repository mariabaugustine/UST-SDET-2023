using DailyWork.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public int Number1 {  get; set; }
        public int Number2 { get; set; }
        
        public void Divide()
        {
            
                int[] numbers = { 10, 20, 30 };

                int result =Number1/Number2;
                Console.WriteLine("Result:"+result);
                for(int i=0;i<=3;i++)
                {
                    int res = numbers[i] / Number2;
                    Console.WriteLine(res);
                }
                //foreach (var number in numbers)
                //{
                //    result = number / Number2;
                //    Console.WriteLine("RESULT:" + result);
                //}
           
           
        }
        public void NumberCheck1()
        {
            if (Number1 > 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Number1Exception(MyExceptions.exceptionmessage[4]);
            }

        }
        public void NumberCheck2()
        {
            if(Number2<100)
            {
                Console.WriteLine("Congrats");

            }
            else
            {
                throw new Number2Exception(MyExceptions.exceptionmessage[4]);
            }
        }
    }
}
