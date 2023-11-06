using CaseStudy;
using CaseStudy.CustomException;
using System;
using System.Reflection.Metadata.Ecma335;
//int choice;
//double total;
//Book[] book = new Book[1];
////Customer[] customers = new Customer[1];
//Console.WriteLine("******************************************Online Book Store*********************************");
//Console.WriteLine("1.Add Book\n2.Add Customer\n3.View Books\n4.Search Book\n5.Place Order\n7.Exit");
//do
//{
//    switch (Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            //Console.WriteLine("Enter the number of book do you want to add:");
//            //num=Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < book.Length; i++)
//            {
//                Console.Write("Enter the Book Title:");
//                string? Title = Console.ReadLine();
//                Console.Write("Enter the Autor");
//                string? Author = Console.ReadLine();
//                Console.Write("Enter the ISBN");
//                int ISBN = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Price");
//                double Price = Convert.ToDouble(Console.ReadLine());
//                Console.Write("Enter the Availability:");
//                string? Availability = Console.ReadLine();
//                Console.Write("Enter the Type:");
//                string? Type = Console.ReadLine();
//                book[i] = new Book(Type, Title, Author, ISBN, Price, Availability);
//            }

//            break;
//        case 2:

//            Console.WriteLine("Enter the Customer Id");
//            int id=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Customer Name:");
//            string CustomerName=Console.ReadLine();
//            Console.WriteLine("Contact Details:");
//            string?mobile=Console.ReadLine();
//            Customer customers=new Customer(id,CustomerName,mobile);




//            break;
//        case 3:
//            foreach (var item in book)
//            {
//                item.DisplayBooks(item);
//            }

//            break;
//        case 4:
//            Console.Write("Enter the Book Title To Search:");
//            string? Title1 = Console.ReadLine();
//            foreach (var item in book)
//            {
//                if(item.Title==Title1)
//                {
//                    Console.WriteLine("Title:"+item.Title);
//                    Console.WriteLine("Price:" + item.Price);
//                    Console.WriteLine("Availability:" + item.Availability);
//                }
//                else
//                {
//                    Console.WriteLine($"{0} is not availabile",Title1);
//                }
//            }

//            break;
//        case 5:
//            Console.Write("Enter the Book Title To Search:");
//            string? Title2 = Console.ReadLine();
//            foreach(var item in book)
//            {
//                if(item.Title==Title2)
//                {
//                    Console.WriteLine("enter the order date:");
//                    string date = Console.ReadLine();
//                    Console.WriteLine("Order placed!!");
//                    total = item.Price;

//                    Order order1 = new Order(date,total);
//                    order1.OrderDetails();
//                    Console.WriteLine("Title2:"+Title2);
//                    Console.WriteLine("Price:"+item.Price);


//                }

//            }

//                break;
//    }
//    Console.WriteLine("Do you wish to Continue?\n 1.Yes\n2.No");
//    choice=Convert.ToInt32(Console.ReadLine());

//} while (choice!=2);
/***************************************************************************************************************/
internal class Program
{
    public delegate void Delegate1(List<Student>Students);
    public delegate void Delegate2(int id);
    public static void Main(string[] args)
    {
        try
        {


            Console.WriteLine("************************************************Student Enrollment System*******************************");
            while (true)
            {
                Console.WriteLine("Enter the choice \n1.Admin\n2.Student");
                int choice = Convert.ToInt32(Console.ReadLine());
                while (true)
                {

                    if (choice == 1)
                    {
                        Console.WriteLine("Choose option\n1.Add Course\n2.Generate Report");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.Write("Enter the course code:");
                                int code = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the title:");
                                string? title = Console.ReadLine();
                                Console.Write("Enter the instructor");
                                string? inst = Console.ReadLine();
                                Console.Write("Enter the maximum count");
                                int count = Convert.ToInt32(Console.ReadLine());
                                Course course = new Course();
                                course.CourseCode = code;
                                course.Title = title;
                                course.Instructor = inst;
                                course.MaxCount = count;
                                Course.courses.Add(course);
                                break;
                            case 2:
                                Course course1 = new Course();
                                Console.WriteLine("******************All Courses***********************");
                                foreach(var item in Course.courses)
                                {
                                    Console.WriteLine($"Course code:{item.CourseCode}\tCourse Title:{item.Title}\tInstructor:{item.Instructor}");
                                }
                                Console.WriteLine("*****************Enrolled Student Details*********************");
                                foreach (var data in course1.EnrolledStudent)
                                {
                                    Console.WriteLine($"Name:{data.Name}\tId:{data.StudentId}\tEmail:{data.Email}");
                                }
                                break;
                        }
                        Console.WriteLine("Do you want to continue as a admin\n1.Yes\n2.No");
                        int opst = Convert.ToInt32(Console.ReadLine());
                        if (opst == 1)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Enter the choice:\n1.Student Registration\n.2Course Enrollment\n3.Course withdrawal");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.Write("Enter the student Id:");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the Name:");
                                string? name = Console.ReadLine();
                                Console.WriteLine("Enter the email id");
                                string? email = Console.ReadLine();
                                Student student = new Student();
                                student.StudentId = id;
                                student.Name = name;
                                student.Email = email;
                                Student.Students.Add(student);
                                Console.WriteLine("Student added successully");


                                break;
                            case 2:
                                Console.WriteLine("Choose the course");

                                Course course = new Course();
                                Student student1 = new Student();

                                course.CourseRegistration(Student.Students);
                                break;
                            case 3:
                                Console.WriteLine("Enter the course do you want to withdraw");
                                int eid = Convert.ToInt32(Console.ReadLine());
                                WithdrawAsync(eid);
                                break;


                        }
                        Console.WriteLine("Do you want to continue as a student\n1.Yes\n2.No");
                        int opst = Convert.ToInt32(Console.ReadLine());
                        if (opst == 1)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                }

            }
        }

        catch (EnrollmentException ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static async Task CourseEnrollAsync(List<Student>Students)
    {
        Course c1= new Course();
        await Task.Delay(2000);
        Delegate1 delegate1 = new Delegate1(c1.CourseRegistration);
        delegate1.Invoke(Students);

    }
    public static async Task WithdrawAsync(int id)
    {
        Course c2= new Course();
        await Task.Delay(2000);
        Delegate2 delegate2 = new Delegate2(c2.CourseWithdrawl);
        delegate2.Invoke(id);
    }
}