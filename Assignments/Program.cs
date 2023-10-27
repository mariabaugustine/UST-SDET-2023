using Assignments;
using Assignments.MyException;
using System.Threading.Channels;
//using System.Transactions;
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
//********************************************STUDENT(19/10/2023*********************************
//Students[] students = new Students[3];
//students[0] = new Students("Abi", new int[] { 30, 60, 80 });
//students[1] = new Students("Bhagya", new int[] { 90, 87, 94 });
//students[2] = new Students("Athira", new int[] { 89, 85, 96 });
//Console.WriteLine("*********************STUDENT DETAILS******************************");
//Console.WriteLine();
//foreach (var student in students)
//{
//    Console.WriteLine("Student Name:" + student.Name);
//    Console.Write("Mark:");
//    foreach (var student2 in student.Marks)
//    {
//        Console.Write(student2 + ",");

//    }
//    Console.WriteLine("\nTotal:" + student.Marks.Sum());
//    Console.WriteLine("Average:" + student.Marks.Average());
//    Console.WriteLine("Grade:" + student.CalculateGrade());
//    Console.WriteLine(student.GetMarkSummary());
//    Console.WriteLine();
//}
/************************************************20/10/2023**********************************************/
//ElectronicProduct electronicProduct=new ElectronicProduct("TV",12434,3,5);
//Console.WriteLine($"Product Name:{0}\nPrice:{1}\nQuantity:{2}\nWarranty Period:{3}"+electronicProduct.ProductName,electronicProduct.Price,electronicProduct.Quantity,electronicProduct.WarrantyPeriod);
//electronicProduct.DisplayDetails();
//Console.WriteLine("Warranty Period:"+electronicProduct.DisplayWarrantyPeriod());
/*******************************************************************************************************/
//DigitalProduct digitalProduct = new DigitalProduct("pdf", "Mobile", 45000, 4, 3);
//digitalProduct.DisplayDetails();
//Console.WriteLine("Warranty Period:" +digitalProduct.DisplayWarrantyPeriod());
//Console.WriteLine("File Format:"+digitalProduct.DisplayFileFormat());
/******************************************************************************/
//ClothingProduct cp = new ClothingProduct("Fridge", 23000, 3, "4.5");
//cp.DisplayDetails();
//Console.WriteLine("Size:" +cp.DisplaySize());
/**************************************************************************/
//Console.Write("Enter the employee Id:");
//int id = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the first Name:");
//string firstName = Console.ReadLine();
//Console.Write("Enter the Last Name:");
//string lastName = Console.ReadLine();
//Console.Write("Enter the Age:");
//int age = Convert.ToInt32(Console.ReadLine());

//Employee employee = new Employee(firstName, lastName, age, id);
//employee.DisplayInfo(age);
/*************************************************************************/
//Console.Write("Enter the Radius:");
//double radius=Convert.ToDouble(Console.ReadLine());
//Circle circle=new Circle(radius);
//circle.Draw();
//Console.WriteLine("Area:"+circle.CalculateArea());
//Console.WriteLine("Perimeter:"+circle.CalculatePerimeter());
//Console.Write("Enter the Length:");
//double length = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the Width:");
//double width=Convert.ToDouble(Console.ReadLine());
//Rectangle rectangle = new Rectangle(length, width);
//rectangle.Draw();
//Console.WriteLine("Area:"+rectangle.CalculateArea());
//Console.WriteLine("Perimeter:"+rectangle.CalculatePerimeter());
//Console.Write("Enter the PolicyId:");
//int policyId = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Policy Name:");
//string policyName=Console.ReadLine();
//Console.Write("Enter the Premium Amount:");
//double premiumAmount=Convert.ToDouble(Console.ReadLine());
//InsurancePolicy policy = new InsurancePolicy(policyId,policyName,premiumAmount);
//Console.Write("Enter the Renewed Premium Amount:");
//double NAmount=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Renewed Policy"+policy.RenewPolicy(NAmount));
//Console.Write("Premium Amount:" + policy.RenewPolicy());
/**********************************************************************************************************/
//Console.Write("Enter the PolicyId:");
//int policyId = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Policy Name:");
//string policyName = Console.ReadLine();
//Console.Write("Enter the Policy Amount:");
//double premiumAmount = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the age:");
//int age=Convert.ToInt32(Console.ReadLine());
//LifeInsurance lifeInsurance=new LifeInsurance(policyId,policyName,premiumAmount,age);
//Console.WriteLine("Premium Amount:"+lifeInsurance.CalculatePremium());
//Console.Write("Enter the PolicyId:");
//int policyId1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Policy Name:");
//string policyName1 = Console.ReadLine();
//Console.Write("Enter the Policy Amount:");
//double premiumAmount1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the car type:");
//string type = Console.ReadLine().ToLower();
//CarInsurance car = new CarInsurance(policyId1, policyName1, premiumAmount1, type);
//Console.WriteLine(car.CalculatePremium());
/***********************************************************************************************/
//Customer customer=new Customer();
//customer.DisplayDetails();
//Console.Write("Enter the Phone number:");
//long number = Convert.ToInt64(Console.ReadLine());
//customer.SearchDetails(number);
/*************************************************************************************************/
//CallRecord record = new CallRecord();
//Console.WriteLine("Enter the phone number");
//long number=Convert.ToInt64(Console.ReadLine());
//CallRecord.CallHistory(number);
//CallRecord.CallCounts();
/****************************************************************************************************/
//Patient patient = new Patient();
//Console.Write("Enter the patient Id:");
//int id=Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Name:");
//string name=Console.ReadLine();
//Console.Write("Enter the Age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Diagnosis:");
//string diagnosis = Console.ReadLine();
//try
//{
//    patient.AddPatient(id, name, age, diagnosis);

//}
//catch(MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}
/*****************************************************************27/10/2023*****************************/
MedicalRecord medicalRecord = new MedicalRecord();


        Console.Write("Enter the patient Id:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the record Id:");
        int r_id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Name:");
        string name = Console.ReadLine();
        Console.Write("Enter the Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Diagnosis:");
        string diagnosis = Console.ReadLine();
        Console.Write("Enter the treatment cost:");
        double cost = Convert.ToDouble(Console.ReadLine());
        try
        {
            medicalRecord.AddMedicalRecord(r_id, id, name, age, diagnosis, cost);
            medicalRecord.DisplayDetails();
        }
        catch (InvalidMedicalRecordException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidPatientDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
       

/***************************************************************************************************/
Console.WriteLine("Enter the choice:");
Console.WriteLine("1.Add Patient Record\n2.View Patient Record\n3.Exit");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        Console.Write("Enter the patient Id:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Name:");
        string name = Console.ReadLine();
        Console.Write("Enter the Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Diagnosis:");
        string diagnosis = Console.ReadLine();

        break;
    case 2:
        break;
    case 3:
        break;
}

