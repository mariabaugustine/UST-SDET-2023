using Assignments.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public int PatientID { get; set; }
        public string? PatientName { get; set;}

        public int Age {  get; set; }

        public string? Diagnosis {  get; set; }
        List<Patient> patients = new List<Patient>();
        public void AddPatient(int id,string?name,int age,string?diagnosis)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new MyExceptions(CustomException.exceptionmessage[2]);
            }
           else if (age < 0 ||age >= 120)
            {
                throw new MyExceptions(CustomException.exceptionmessage[1]);
            }
           else if (string.IsNullOrEmpty(diagnosis))
            {
                throw new MyExceptions(CustomException.exceptionmessage[3]);
            }
            else
            { 
                patients.Add(new Patient { PatientID = id, PatientName = name, Age = age, Diagnosis = diagnosis });

            }
        }
        public void AddPatientTextFile(int id,string name,int age,string diagnosis)
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient\\patient.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Patient Id:"+id);
            writer.WriteLine("Patient Name:"+name);
            writer.WriteLine("Age:"+age);
            writer.WriteLine("Diagnosis:"+diagnosis);
            writer.Close();
            fileStream.Close();


        }
        public void ReadDetails()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient\\patient.txt",FileMode.Open,FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string str=reader.ReadToEnd();
            Console.WriteLine(str);
            reader.Close();
            fileStream.Close ();
        }
      

    }
}
