using CaseStudy;
using CaseStudy.CustomException;
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
try
{
    Customers customers1 = new Customers();
    customers1.CustomerID = 100;
    customers1.CustomerName = "Arya";
    customers1.CustomerEmail = "arya@ust";
    Customers.customers.Add(customers1);
    Customers customers2 = new Customers();
    customers2.CustomerID = 101;
    customers2.CustomerName = "brunda";
    customers2.CustomerEmail = "brunda@ust";
    Customers.customers.Add(customers2);
    PhysicalProduct physicalProduct = new PhysicalProduct();
    physicalProduct.Name = "TV";
    physicalProduct.ProductId = 2;
    physicalProduct.Weight = 1;
    physicalProduct.Price = 45000;
    physicalProduct.Dimensions = "130";
    physicalProduct.StockQuantity = 25;
    PhysicalProduct.Products.Add(physicalProduct);
    DigitalProduct digitalProduct = new DigitalProduct();
    digitalProduct.Name = "Watch";
    digitalProduct.ProductId = 1;
    digitalProduct.Price = 4500;
    digitalProduct.StockQuantity = 20;
    digitalProduct.FileFormat = "jpg";
    digitalProduct.DownloadLink = "www.digital.com";
    DigitalProduct.Products.Add(digitalProduct);


    Console.WriteLine("******************************E-Commerce System*********************************************");
    Console.WriteLine("Enter the customer id");
    int cusId = Convert.ToInt32(Console.ReadLine());
    
    while (true)
    {
        if (Customers.customers.Find(x => x.CustomerID == cusId) == null)
        {
            Console.WriteLine("Customer not found");
            break;
        }
        Console.WriteLine("Choose your option\n1.View allproduct\n2,Add product to cart\n3.Place order\n4.view orders\n5.Support");
        //Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
        int optionuser = Convert.ToInt32(Console.ReadLine());
        switch (optionuser)
        {

            
            case 1:
                Console.WriteLine("Products are");
                if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                {
                    throw new OrderException(MyException.Errors[3]);
                }
                foreach (var item in DigitalProduct.Products)
                {
                    Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                        item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                }
                foreach (var item in PhysicalProduct.Products)
                {
                    Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                        "\tDimension:{5}", item.ProductId,
                        item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                }
                break;
            case 2:

                Console.WriteLine("Enter Product id for add to cart");
                int productId = Convert.ToInt32(Console.ReadLine());
                Customers customer1 = Customers.customers.Find(x => x.CustomerID == cusId);
                if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                {
                    if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        Console.WriteLine("invalid product id");
                    }
                    else
                    {
                        customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
                    }
                }
                else
                {
                    customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                    Console.WriteLine("product added to cart");
                }
                break;
            case 3:
                Customers customer = Customers.customers.Find(x => x.CustomerID == cusId);
                if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                {
                    Console.WriteLine("Cart is empty");
                }
                else
                {
                    foreach (var item in customer.orders)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                         item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                        item.PlacingOrder();
                        item.ProceesingPayment();
                        item.DeleveringProduct();

                    }
                    foreach (var item in customer.ordersphy)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                       "\tDimension:{5}", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                        item.PlacingOrder();
                        item.ProceesingPayment();
                        item.DeleveringProduct();
                        Console.WriteLine("Order placed successfully");
                    }
                    Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                    int confirm = Convert.ToInt32(Console.ReadLine());
                    if (confirm == 1)
                    {
                        customer.confirmedorders.AddRange(customer.orders);
                        customer.orders.Clear();
                        customer.confirmedordersphy.AddRange(customer.ordersphy);
                        customer.ordersphy.Clear();
                        Console.WriteLine("order placed successfully");
                    }
                    else
                    {
                        Console.WriteLine("removing everything in cart");
                    }


                }



                break;
            case 4:
                Customers customer2 = Customers.customers.Find(x => x.CustomerID == cusId);
                if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                {
                    Console.WriteLine("no order details found");
                }
                else
                {
                    Console.WriteLine("Orders are");
                    foreach (var item in customer2.confirmedorders)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                        item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in customer2.confirmedordersphy)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                       "\tDimension:{5}", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                    }
                }
                break;
                
            case 5:
                Console.WriteLine("For enquiry:9496739548");
                break;
            default:
                Console.WriteLine("invalid input");

                break;
        }

        Console.WriteLine("do you want to continue \n1.yes\n2.No");
        int optUser = Convert.ToInt32(Console.ReadLine());
        if (optUser == 1)
        {
            continue;
        }
        else if (optUser == 2)
        {
            break;
        }
        else
        {
            Console.WriteLine("invalid input");
        }


    }


    
}
catch(OrderException ex)
{
    Console.WriteLine(ex.Message);
}