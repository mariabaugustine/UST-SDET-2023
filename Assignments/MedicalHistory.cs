using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public int RecordId {  get; set; }
        public int PatientId {  get; set; }

        public string Description {  get; set; }

        public string Date { get; set; }
    }
}
