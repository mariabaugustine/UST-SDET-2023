using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public int PackageId {  get; set; }
        public string? Destination {  get; set; }

        public string? StartDate {  get; set; }

        public double Price {  get; set; }

        public static List<TourPackage>TourPackageList=new List<TourPackage>();

        public TourPackage(int packageId, string? destination, string? startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public static void ReserveTourPackage()
        {
            Console.Write("Enter the package id:");
            int id=Convert.ToInt32(Console.ReadLine());
            lock(TourPackageList)
            {
                var data=TourPackageList.Find(X=> X.PackageId == id);
                if(data != null) 
                {
                    Console.WriteLine("Package Details:\nPackage Id:"+data.PackageId+"\n"+"Destination:"+data.Destination+"\n"+"Start Date:"+data.StartDate+"\n"+"Price:"+data.Price);
                }
                else 
                {
                    Console.WriteLine("No details found");
                 }
            }
        }
    }
}
