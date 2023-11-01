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
//MedicalRecord medicalRecord = new MedicalRecord();


//        Console.Write("Enter the patient Id:");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter the record Id:");
//        int r_id = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter the Name:");
//        string name = Console.ReadLine();
//        Console.Write("Enter the Age:");
//        int age = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter the Diagnosis:");
//        string diagnosis = Console.ReadLine();
//        Console.Write("Enter the treatment cost:");
//        double cost = Convert.ToDouble(Console.ReadLine());
//        try
//        {
//            medicalRecord.AddMedicalRecord(r_id, id, name, age, diagnosis, cost);
//            medicalRecord.DisplayDetails();
//        }
//        catch (InvalidMedicalRecordException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        catch (InvalidPatientDataException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }


/***************************************************************************************************/
//Patient patient = new Patient();
//int option=1;
//do
//{
//    Console.WriteLine("Enter the choice:");
//    Console.WriteLine("1.Add Patient Record\n2.View Patient Record\n3.Exit");
//    switch (Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            Console.Write("Enter the patient Id:");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Name:");
//            string name = Console.ReadLine();
//            Console.Write("Enter the Age:");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Diagnosis:");
//            string diagnosis = Console.ReadLine();
//            patient.AddPatientTextFile(id, name, age, diagnosis);
//            break;

//            case 2:
//            patient.ReadDetails();
//            break;

//        case 3:
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;

//    }  
//    Console.WriteLine("Do you wish to continue?\n1.Yes\n2.No");
//    option=Convert.ToInt32(Console.ReadLine());
//}
//while(option!=2);
/***********************************************************************************************/
//MedicalHistory medicalHistory = new MedicalHistory();
//int option = 1;
//do
//{
//    Console.WriteLine("Enter the choice:");
//    Console.WriteLine("1.Add Patient Record\n2.View Patient Record\n3.Exit");
//    switch (Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            Console.Write("Enter the record Id:");
//            int r_id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the patient Id:");
//            int p_id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Description:");
//            string description = Console.ReadLine();
//            Console.Write("Enter the Date:");
//            string date = Console.ReadLine();
//            medicalHistory.AddMedicalHistory(r_id, p_id, description, date);
//            medicalHistory.AddToFile(r_id, p_id, description, date);
//          break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }
//    Console.WriteLine("Do you wish to continue?\n1.Yes\n2.No");
//    option=Convert.ToInt32(Console.ReadLine());
//} while (option != 2);
/*Console.WriteLine("Enter the room number");
int r_no=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Room Type:Single/Double");
string?r_type=Console.ReadLine();
RoomReservation<HotelRoom>room_res= new RoomReservation<HotelRoom>();
HotelRoom room=new HotelRoom(r_no,r_type,true);
room_res.BookRoom(room);
Console.WriteLine("Booking Details");

    foreach(var item in RoomReservation<HotelRoom>.Room)
{
    Console.WriteLine("Room  Number:" + item.RoomNumber);
    Console.WriteLine("Room Type:" + item.RoomType);
    Console.WriteLine("Status:"+item.IsBooked);
}
Console.WriteLine("Enter the room number");
int roomnumber=Convert.ToInt32(Console.ReadLine());
var data=RoomReservation<HotelRoom>.Room.Find(X=>X.RoomNumber==roomnumber);
if(data!=null)
{
    room_res.CancelRoom(data);
    Console.WriteLine("Booking canceled successfully");
}
else
{
    Console.WriteLine("No record found");
}*/
//Inventory<string> inventory = new Inventory<string>();
//int option;
//do
//{
//    Console.WriteLine("Enter the choice\n1.Add Product\n2.Update Product\n3.Remove Product\n4.Search By Id\n5.Search By Name");
//    switch(Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            Console.WriteLine("Enter the product Id:");
//            int id=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the name:");
//            string?name=Console.ReadLine();
//            Console.WriteLine("Enter the price:");
//            double price=Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter the product quantity:");
//            double quantity=Convert.ToDouble(Console.ReadLine());
//            inventory.AddProduct(new GProduct<string>(id, name, price, quantity));
//            break;
//            case 2:
//            Console.WriteLine("Enter the product id to update:");
//            int p_id=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the product name");
//            string?u_name=Console.ReadLine();
//            Console.WriteLine("Enter the price:");
//            double u_price=Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter the quantity:");
//            double u_quantity=Convert.ToDouble(Console.ReadLine());
//            inventory.UpdateProduct(p_id, u_name, u_price, u_quantity);
//            break;
//        case 3:
//            Console.WriteLine("Enter the product id");
//            int d_id=Convert.ToInt32(Console.ReadLine());
//            inventory.DeleteProduct(d_id);
//            break;
//        case 4:
//            Console.WriteLine("Enter the Product id");
//            int s_id = Convert.ToInt32(Console.ReadLine());
//            GProduct<string> proList=inventory.SearchProductById(s_id);
//            if(proList != null)
//            {
//                Console.WriteLine("Product Id:"+proList.ProductId);
//                Console.WriteLine("Name:"+proList.Price);
//                Console.WriteLine("Price:"+proList.QuantityInStock);

//            }
//            else
//            {
//                Console.WriteLine("List is empty");
//            }

//    }
//

//class Program
//{
//    public delegate decimal BonusCalculation(Employees employees);

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the employee id:");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter the name:");
//        string? name = Console.ReadLine();
//        Console.WriteLine("Enter the performance rating(1 to 5):");
//        int rating = Convert.ToInt32(Console.ReadLine());
//        Employees employees = new(id, name, rating);
//        Employees.AddEmployee(employees);
//        Console.WriteLine("Enter your choice:\n1.Performance based bonus \n2.Department specific Bonus\n3.Exit");
//        switch (Convert.ToInt32(Console.ReadLine()))
//        {
//            case 1:
//                BonusCalculation bonusCalculation = Employees.PerformanceBasedBonus;
//                Console.WriteLine("Bonus:"+bonusCalculation(employees));


//                break;
//            case 2:
//                BonusCalculation bonusCalculation1 = Employees.DepartmentBonus;
//                Console.WriteLine("Bonus:"+bonusCalculation1(employees));

//                break;
//            case 3:
//                break;
//        }
//    }
//}
//class Program
//{
//    public delegate string EventBooking(string message);
//    public static void Main(string[] args)
//    {
//        HotelEvent hotelEvent = new HotelEvent("Wedding", "12/10/2024","Trivandrum",100);
//        EventBooking eventBooking = HotelEvent.EventRegistration;
//        if (eventBooking == null) 
//        {
//            Console.WriteLine(eventBooking("Not Registered"));
//        }
//        else
//        {
//            Console.WriteLine(eventBooking("Event successfully registered"));
//        }
//    }
//}

//TourismDestination tourism1 = new TourismDestination("Munnar", "India", 4);
//TourismDestination tourism2 = new TourismDestination("Gavi", "India", 2);
//TourismDestination tourism3 = new TourismDestination("Varkala", "India", 3);
//TourismDestination.tourismDestinations.Add(tourism1);
//TourismDestination.tourismDestinations.Add(tourism2);
//TourismDestination.tourismDestinations.Add(tourism3);
//TourismDestination.SortngDestination();
TourismDestination1 tourism1 = new TourismDestination1("Dungeness","UK",4,9875);
TourismDestination1 tourism2 = new TourismDestination1("Goa","India",3,3500);
TourismDestination1 tourism3 = new TourismDestination1("Melbourne","Australia",3,7450);
TourismDestination1.tourismDestination1.Add(tourism1);
TourismDestination1.tourismDestination1.Add(tourism2);
TourismDestination1.tourismDestination1.Add(tourism3);
TourismDestination1.DisplayTopRated();
TourismDestination1.SortedDestination();
TourismDestination1.FilterDestination();

