using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class FileOperation
    {
        public void CreateFile()
        {
            FileInfo fileInfo = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\sample.text");
            using StreamWriter str=fileInfo.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("Hello There");
            str.WriteLine("Hi");
            str.WriteLine("written");
        }
    }
}
