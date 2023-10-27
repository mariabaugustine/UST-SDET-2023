using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.MyException
{
    internal class CustomException
    {
        public static Dictionary<int, string> exceptionmessage = new Dictionary<int, string>()
        {
            {1,"Age Should be between 0 and 120" },
            {2,"Patient name cannot be null" },
            {3,"Diagnosis cannot be null" },
            {4,"The patient name and diagnosis should not be empty" },
            {5,"The treatment cost should be positive" }
           
        };
    }

    internal class MyExceptions : Exception
    {
        public MyExceptions(string message) : base(message)
        {
        }
    }
    internal class InvalidPatientDataException:Exception
    {
        public InvalidPatientDataException(string message) : base(message)
        {
        }
    }
    internal class InvalidMedicalRecordException:Exception
    {
        public InvalidMedicalRecordException(string message) : base(message)
        {
        }
    }

}
