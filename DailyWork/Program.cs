﻿using DailyWork;
using DailyWork.ExceptionMessages;

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
//ExceptionHandling exceptionHandling = new(3, 5);
//try
//{
//    exceptionHandling.NumberCheck();
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    exceptionHandling.Divide();
//}
//catch (ArithmeticException ex)
//{
//    Console.WriteLine(MyExceptions.exceptionmessage[0]);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Source);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyExceptions.exceptionmessage[1]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(MyExceptions.exceptionmessage[2]);
//}
//try
//{
//    exceptionHandling.NumberCheck1();
//}
//catch(Number1Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    exceptionHandling.NumberCheck2();

//}
//catch(Number2Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
/*****************************************************************************************************/
//FileOperation operation = new();
//operation.CreateFile();
//operation.WriteData();
//operation.ReadData();
//operation.CopyMoveFile();
//operation.DeleteFile();
//operation.FileProperties();

/*************************************************************************************************************/
//GenericExample<int> g1 = new(12, 21);
//Console.WriteLine(g1.Val1+"     "+g1.Val2);

//GenericExample<double> g2 = new(12.456, 21.678);
//Console.WriteLine(g2.Val1 + "     " + g2.Val2);

//GenericExample<string> g3 = new("abc","def");
//Console.WriteLine(g3.Val1 + "     " + g3.Val2);
//////////////////////////////////////////////////////////////////////////////////////////////////////////
//GenericExample<int>generic=new GenericExample<int>(new int[3] {1,2,3});
//generic.Display();
////////////////////////////////////////////////////////////////////////////////////////////////////////
//static void Swap<T>(ref T num1,ref T num2)
//{
//    T temp;
//    temp = num1;    
//    num1 = num2;
//    num2 = temp;
//}
//int n1=10, n2=10;
//char c1 = 'A', c2 = 'B';
//Swap<int>(ref n1,ref n2);
//Swap<char>(ref c1, ref c2);

public delegate void delegate1(string message);
public delegate void delegate2(int n1,int n2);
public delegate int delegate3(int n1,int n2);
class Program
{
    public static void Main(string[] args)
    {
        delegate1 d1 = DelegateExample.MethodA;
        d1.Invoke("Hello how are you");
        DelegateExample delegateExample = new DelegateExample();
        delegate2 d2 = delegateExample.Add;
       // d2(10,20);
        delegate3 d3 = delegateExample.AddR;
        Console.WriteLine(d3(10,40));
        delegate2 d4 = delegateExample.Sub;
        // d4(45, 5);
        delegate2 dobjall = d2 + d4;
        dobjall(50, 25);

    }
}


