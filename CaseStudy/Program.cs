﻿using CaseStudy;
int choice;
double total;
Book[] book = new Book[1];
//Customer[] customers = new Customer[1];
Console.WriteLine("******************************************Online Book Store*********************************");
Console.WriteLine("1.Add Book\n2.Add Customer\n3.View Books\n4.Search Book\n5.Place Order\n7.Exit");
do
{
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            //Console.WriteLine("Enter the number of book do you want to add:");
            //num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < book.Length; i++)
            {
                Console.Write("Enter the Book Title:");
                string? Title = Console.ReadLine();
                Console.Write("Enter the Autor");
                string? Author = Console.ReadLine();
                Console.Write("Enter the ISBN");
                int ISBN = Convert.ToInt32(Console.ReadLine());
                Console.Write("Price");
                double Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Availability:");
                string? Availability = Console.ReadLine();
                Console.Write("Enter the Type:");
                string? Type = Console.ReadLine();
                book[i] = new Book(Type, Title, Author, ISBN, Price, Availability);
            }

            break;
        case 2:
            
            Console.WriteLine("Enter the Customer Id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Name:");
            string CustomerName=Console.ReadLine();
            Console.WriteLine("Contact Details:");
            string?mobile=Console.ReadLine();
            Customer customers=new Customer(id,CustomerName,mobile);
            
           

            
            break;
        case 3:
            foreach (var item in book)
            {
                item.DisplayBooks(item);
            }

            break;
        case 4:
            Console.Write("Enter the Book Title To Search:");
            string? Title1 = Console.ReadLine();
            foreach (var item in book)
            {
                if(item.Title==Title1)
                {
                    Console.WriteLine("Title:"+item.Title);
                    Console.WriteLine("Price:" + item.Price);
                    Console.WriteLine("Availability:" + item.Availability);
                }
                else
                {
                    Console.WriteLine($"{0} is not availabile",Title1);
                }
            }
            
            break;
        case 5:
            Console.Write("Enter the Book Title To Search:");
            string? Title2 = Console.ReadLine();
            foreach(var item in book)
            {
                if(item.Title==Title2)
                {
                    Console.WriteLine("enter the order date:");
                    string date = Console.ReadLine();
                    Console.WriteLine("Order placed!!");
                    total = item.Price;

                    Order order1 = new Order(date,total);
                    order1.OrderDetails();
                    Console.WriteLine("Title2:"+Title2);
                    Console.WriteLine("Price:"+item.Price);
                   
                    
                }

            }

                break;
    }
    Console.WriteLine("Do you wish to Continue?\n 1.Yes\n2.No");
    choice=Convert.ToInt32(Console.ReadLine());

} while (choice!=2);