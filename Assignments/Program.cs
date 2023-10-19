using Assignments;
//********************************18/10/2023****************************************************
/*Student student = new("Aleena", 50, 40, 80)
Console.WriteLine("Name:" + student.fullname);
Console.WriteLine("Total Mark:" + student.TotalMark());
Console.WriteLine("Average:" + student.CalculateAverage());
Console.WriteLine("Grade:" + student.CalculateGrade());*/

//*********************************19/10/2023***************************************
//Product[] products = new Product[3];
//products[0] = new Product("TV", 56000, 4);
//products[1] = new Product("Mobile", 48000, 3);
//products[2] = new Product("Fridge", 62000, 8);
//Console.WriteLine("************************Product Details*************************");
//foreach (var product in products)
//{
//    Console.WriteLine("Product Name:"+product.ProductName);
//    Console.WriteLine("Price:"+product.Price);
//    Console.WriteLine("Quantity:"+product.Quantity);
//    Console.WriteLine("Total Value:" + product.ProductValue());
//    Console.WriteLine();
//}
//********************************************
Students[] students = new Students[3];
students[0] = new Students("Abi", new int[]{ 30,60,80});
students[1] = new Students("Bhagya", new int[] { 90, 87, 94 });
students[2] = new Students("Athira", new int[] { 89, 85, 96 });
Console.WriteLine("*********************STUDENT DETAILS******************************");
Console.WriteLine();
foreach (var student in students)
{
    Console.WriteLine("Student Name:" + student.Name);
    Console.Write("Mark:");
    foreach (var student2 in student.Marks)
    {
        Console.Write(student2 + ",");

    }
    Console.WriteLine();
    Console.WriteLine("Total:" + student.Marks.Sum());
    Console.WriteLine("Average:" + student.Marks.Average());
    Console.WriteLine("Grade:" + student.CalculateGrade());
    Console.WriteLine(student.GetMarkSummary());
    Console.WriteLine();
}




  