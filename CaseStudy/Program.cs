using CaseStudy;
Book[] book = new Book[1];
Customer[] customers = new Customer[1];
Console.WriteLine("******************************************Online Book Store*********************************");
Console.WriteLine("1.Add Book\n2.Add Customer\n3.View Books\n4.View Customer\n5.Search Book\n6.Place Order\n7.Exit");
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
            string?Type = Console.ReadLine();
            book[i] = new Book(Type, Title, Author, ISBN, Price, Availability);
        }
        
        break;
    case 2:

        break;
    case 3:
           foreach(var item in book)
            {
                item.DisplayBooks(item);
            }
        
        break;
    