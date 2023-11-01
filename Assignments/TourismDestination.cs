using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country= country;
            Rating = rating;
        }

        public string? Name {  get; set; }
        public string? Country {  get; set; }

        public int Rating {  get; set; }


        public static List<TourismDestination> tourismDestinations = new List<TourismDestination>();
        public static void SortngDestination()
        {
           
            var sortedList = tourismDestinations.OrderByDescending(x => x.Rating);
            foreach(TourismDestination dest in sortedList)
            {
                Console.WriteLine("Name:"+dest.Name+"\t"+"Location:"+dest.Country+"\t"+"Rating:"+dest.Rating);
            }
        }

    }
}
