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

            if (name == null)
            {
                throw new MyExceptions(CustomException.exceptionmessage[1]);
            }
            else if (age < 0 && age > 120)
            {
                throw new MyExceptions(CustomException.exceptionmessage[2]);
            }
            else if (diagnosis == null)
            {
                throw new MyExceptions(CustomException.exceptionmessage[3]);
            }
            else
            {
                patients.Add(new Patient { PatientID = id, PatientName = name, Age = age, Diagnosis = diagnosis });

            }
        }
        //public void validation(string name,int age,string diagnosism)
        //{
        //    if(name==null)
        //    {
        //        throw new MyExceptions(CustomException.exceptionmessage[0]);
        //    }
        //    if(age<0 && age>120)
        //    {
        //        throw  new MyExceptions(CustomException.exceptionmessage[1]);
        //    }
        //    if(diagnosism==null)
        //    {
        //        throw new MyExceptions(CustomException.exceptionmessage[2]);
        //    }
        //}
        

    }
}
