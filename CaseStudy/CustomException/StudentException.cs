using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class StudentException
    {
        public static Dictionary<int, string> Errors { get; set; } = new Dictionary<int, string>()
        {
            {1,"Course is full"},
            {2,"Duplicate enrollment" },
           


        };
    }
    internal class EnrollmentException : Exception
    {
        public EnrollmentException(String message) : base(message)
        {
        }
    }
}
