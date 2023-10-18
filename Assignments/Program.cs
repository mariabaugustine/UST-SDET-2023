using Assignments;
Student student = new("Aleena", 50, 40, 80);
Console.WriteLine("Name:"+student.fullname);
Console.WriteLine("Total Mark:"+student.TotalMark());
Console.WriteLine("Average:"+student.CalculateAverage());
Console.WriteLine("Grade:"+student.CalculateGrade());