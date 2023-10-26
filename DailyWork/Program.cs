using DailyWork;
//Console.WriteLine("Enter two numbers");
//double number1, number2, answer;
//number1 = Convert.ToInt32(Console.ReadLine());
//number2 = Convert.ToInt32(Console.ReadLine());
//answer = number1 + number2;
//Console.WriteLine("Answer:" + answer);
//*******************String*******************************************//
//string? s1 = "";
//string? s2 = "";
//string? s3 = "";
//s1=Console.ReadLine();
//s2=Console.ReadLine();
//s3 = s1 + "" + s2;
//Console.WriteLine(s3);
//Console.WriteLine(s1.Equals(s2));
//Console.WriteLine(s1.ToUpper());
//string[] S=s3.Split(' ');
//for(int i = 0; i < S.Length; i++)
//    Console.WriteLine(S[i]);
//******************************************************************//
//using Basic_Programs;

//Calculation calculation = new Calculation();
//int num1=Convert.ToInt32(Console.ReadLine());
//int num2=Convert.ToInt32(Console.ReadLine());
//double result= calculation.add(num1, num2);
//Console.WriteLine(result);
//**********************************************************************//
//Electricity electricity=new ();
//Console.WriteLine(electricity.CalculateBill());

//*************************Employee**************************************//
//Employee employee = new(100, "AAA", "IT", 250000);
//Console.WriteLine("Employee Id:"+employee.Emp_id);
//Console.WriteLine("Name:"+employee.Emp_name);
//Console.WriteLine("Department:"+employee.Department);
//Console.WriteLine("Basic Pay:"+employee.Basic_pay);
//Console.WriteLine("Salary:"+employee.CalculateSalary());
//Console.WriteLine("Employee id:{0} \n" +
//    "Employee Name:{1} \n" +
//    " Basic Pay:{2}\n" +
//    "NetSalary:{3}",
//    employee.Emp_id,
//    employee.Emp_name,
//    employee.Basic_pay,
//    employee.CalculateSalary()
//    ); 
//*************************************Arrays**********************************//
//ArrayExample arrayExample = new ArrayExample();
//arrayExample.Onedim();
//arrayExample.TwoDimensinalAraay();
//arrayExample.JaggedArraay();
/***********************************Inheriance********************************/
//StudentMarks marks = new(90, 97, 98,0, 0,1000, "ABC", "Kochi");
//marks.DisplayStudentDetails();
//Console.WriteLine(marks.CalculateTotalMarks());
//Console.WriteLine(marks.CalculateAverage());
/****************************************************************************/
/*Console.WriteLine("1.Ts 2.NTS");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaffDetails teachingStaffDetails = new TeachingStaffDetails();
        teachingStaffDetails.CollegeName = "CUSAT";
        teachingStaffDetails.Staffid = 100;
        teachingStaffDetails.Staffname = "Aleena";
        teachingStaffDetails.Dept = "cs";
        teachingStaffDetails.Specialization = "Java,C#,DBMS";
        teachingStaffDetails.Sem = 5;
        teachingStaffDetails.DisplayCollegeName();
        teachingStaffDetails.DisplayStaffDetails();
        teachingStaffDetails.DisplayTeachingStaffDetails();
        break;
     case 2:
        NonTeachingStaffDetails nonTeachingStaffDetails = new NonTeachingStaffDetails();
        nonTeachingStaffDetails.Staffid = 200;
        nonTeachingStaffDetails.Staffname = "Anu";
        nonTeachingStaffDetails.Dept = "IT";
        nonTeachingStaffDetails.Responsibilities = "Administration";
        nonTeachingStaffDetails.Experience = 10;
        nonTeachingStaffDetails.DisplayStaffDetails();
        nonTeachingStaffDetails.DisplayNTeachingStaffDetails();
        break;
}
*/
/**************************************************************************************/
/*
EV ev=new EV();
ev.VehicleNumber = 1000;
ev.Brand = "abc";
ev.Model = "defg";
ev.DisplayDetails();
Console.WriteLine(ev.SetVehicleType());

PV pv= new PV();
pv.VehicleNumber = 1005;
pv.Brand="XYZ";
pv.Model = "fgd";
ev.DisplayDetails();
Console.WriteLine(ev.SetVehicleType());
*/
/********************************************INTERFACE***********************************************************/
//IDoctor doctor = new Doctor();
//doctor.AddNewDoctor();
//doctor.ModifyDoctor();
//doctor.DisplayDoctorDetails();
/*--------------------------------------------------------*/
/*Doctor doctor = new Doctor();
doctor.AddNewDoctor();
doctor.ModifyDoctor();
doctor.DisplayDoctorDetails();
doctor.BookApp(111, "Santhosh");
doctor.DelApp(245, "Ravi");*/
//Surgeon surgeon = new Surgeon();
//surgeon.AddNewDoctor();
//surgeon.ModifyDoctor();
//surgeon.DisplayDoctorDetails();
/*************************************BANK(23/10/2023*********************************************/
//BankExample bankExample = new(123, 987654321L, "ABCD", "Inactive");
//BankExample bank = new(567, 123456789L, "QWERT");
//BankExample bank1 = new BankExample();
//BankNew bank1 = new(123, 145789088686L, "MBA", "Active");
//bank1.WelcomeMessage();
//bank1.WelcomeMessage();
//Console.WriteLine("Enter the choice:\n 1.CustomerId\n2.Customer Name\n3.Account Number");
//int ch = Convert.ToInt32(Console.ReadLine());
//switch(ch)
//{
//    case 1:
//        Console.WriteLine("Customer Id:");
//        bank1.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
//        break;
//    case 2:
//        Console.WriteLine("Customer Name:");
//        bank1.GetAccountDetails(Console.ReadLine());
//        break;
//    case 3:
//        Console.WriteLine("Account Number:");
//        bank1.Equals(Convert.ToInt64(Console.ReadLine()));
//        break;
//    default:
//        Console.WriteLine("Inavalid Operation");
//        break; 
//}
//NGC nGC = new NGC();
//nGC.ArraayListHandling();

//nGC.QueueHandling();
//nGC.StackHandling();
//nGC.HtHandling();
//nGC.SLHandling();
//DailyWork.GC gC = new();
//gC.ListHandling();
//gC.StackHandling();
//gC.QueueHandling();
ExceptionHandling exceptionHandling = new(12, 5);
exceptionHandling.Divide();
