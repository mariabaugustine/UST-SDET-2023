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
            try
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
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
