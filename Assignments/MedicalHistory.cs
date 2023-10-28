using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments
{
    internal class MedicalHistory
    {
        public int RecordId {  get; set; }
        public int PatientId {  get; set; }

        public string Description {  get; set; }

        public string Date { get; set; }
         
        public static List<MedicalHistory>MedicalHistoryList=new List<MedicalHistory>();
       
        public  void AddMedicalHistory(int record_id,int patient_id,string description,string date)
        {
         MedicalHistoryList.Add(new MedicalHistory { RecordId = record_id, PatientId = patient_id, Description = description, Date = date });
        }
        public void AddToFile(int record_id, int patient_id, string description, string date)
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient\\MedicalHistory.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write("Record Id:" +record_id+"\t");
            writer.Write("Patient Id:" +patient_id+"\t");
            writer.Write("Description:" +description+"\t");
            writer.Write("Date:" + date+ "\t");
            writer.Close();
            fileStream.Close();
        }
        public void ReadDataFromFile()
        {

        }
    }
}
