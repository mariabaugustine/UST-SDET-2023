using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel:TourismDestination1
    {
        public Hotel(string? name, string? country, int rating, double pricePerNight,string? hotelname,int availabilerooms) : base(name, country, rating, pricePerNight)
        {
            HotelName = hotelname;
            AvailabileRooms = availabilerooms;

        }

        public string? HotelName {  get; set; }
        public int AvailabileRooms {  get; set; }

        public async Task BookRooms(string?hotelName,int requestedRoom)
        {
            if(requestedRoom <=AvailabileRooms)
            {
                Console.WriteLine($"Booking {hotelName}.... ");
                await Task.Delay(2000);
                AvailabileRooms = AvailabileRooms - requestedRoom;
                Console.WriteLine($"Booking confirmed: {requestedRoom} rooms in {HotelName}");
            }
            else
            {
                Console.WriteLine($"Sorry  insufficient rooms availabile in {HotelName}");
                
            }
            Console.WriteLine($"Current availability in {HotelName}: {AvailabileRooms}\n");
        }
    }
}
