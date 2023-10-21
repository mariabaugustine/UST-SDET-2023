using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class ArrayExample
    {
        //int[] numbers = { 10, 20, 30 };
        //if you declare array with readonly we can't change the size but we can  assign value to array.readonly can't use with local variable
        readonly int[] numbers = new int[5];
        int[,] nums = new int[2, 2];
        public void Onedim()
        {
            //int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 2;
            numbers[2] = 5;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("After reinitialization");
            //numbers =new int[6];
            numbers[1] = 3;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //or

            //Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }


        public void TwoDimensinalAraay()
        {
            nums[0, 0] = 100;
            nums[0, 1] = 50;
            nums[1, 0] = 150;
            nums[1, 1] = 200;
            Console.WriteLine("2 DIMENSIONAL ARRAY");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        //**************************************Jagged Array****************************************//
        public void JaggedArraay()
        {
            int[][,] numbs = new int[][,]
            {
                new int[,] { { 1, 2 }, { 3, 4 } },
                new int[,] { { 100, 200,600 },{ 300, 400 ,700} },
                new int[,] { { 150, 250, 350 }, { 25, 35, 45 }, { 100,200,300} }

            };
            Console.WriteLine("Jagged Array");
            //    foreach (var item in numbs)
            //    {
            //        Console.WriteLine(item[0,0]);
            //    }
            for (int i = 0; i < numbs.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < numbs[i].GetLength(x); j++)
                {
                    for (int k = 0; k < numbs[j].Rank; k++)
                    {
                        Console.Write(numbs[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }

    }
}
