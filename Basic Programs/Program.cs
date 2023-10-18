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
using Basic_Programs;
//Electricity electricity=new ();
//Console.WriteLine(electricity.CalculateBill());
Electricity electricity = new(12345, 9000, 9600, "xx");
Console.WriteLine(electricity.CalculateBill());

