using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T> where T : HotelRoom
    {
        public static List<T>Room=new List<T>();
        public void BookRoom(T room)
        {
            Room.Add(room);
        }
        public void CancelRoom(T room) 
        {
            Room.Remove(room);
        }
    }
}
