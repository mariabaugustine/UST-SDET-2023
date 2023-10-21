using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book:BookType
    {
        public Book(string Type,string? title, string? authors, int iSBN, double price, string? availability):base(Type)
        {
            Title = title;
            Authors = authors;
            ISBN = iSBN;
            Price = price;
            Availability = availability;
        }

        public string? Title {  get; set; }
        public string ?Authors {  get; set; }

        public int ISBN { get; set; }

        public double Price {  get; set; }

        public string ?Availability {  get; set; }
        
       public void DisplayBooks(Book book1)
        {
                Console.WriteLine("Title:"+Title);
        }
       


    }
}
