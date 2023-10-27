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
            using StreamWriter str = fileInfo.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("Hello There");
            str.WriteLine("Hi");
            str.WriteLine("written");
        }
        public void WriteData()
        {
            FileStream stream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\sample1.text", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            Console.WriteLine("Enter the text which you want to write to the file");
            string? str = Console.ReadLine();
            writer.WriteLine(str);
            writer.Flush();
            writer.Close();
            stream.Close();


        }
        public void ReadData()
        {
            FileStream stream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\sample1.text", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = reader.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = reader.ReadLine();
            }
            reader.Close();
            stream.Close();
        
        }
        public void CopyMoveFile()
        {
            FileInfo info = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\sample.text");
            FileInfo info1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\sample1.text");
            info.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\" + "sample.text");
            info.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp2\\" + "sample.text");


        }
        public void DeleteFile()
        {
            FileInfo info = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\sample1.text");
            info.Delete();
        }
        public void FileProperties()
        {
            FileInfo info = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\sample.text");
            Console.WriteLine(info.FullName);
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.LastWriteTime);
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Attributes);
            
        }

    }
}
