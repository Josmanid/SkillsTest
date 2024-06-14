using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    internal class GymHall
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        Dictionary<int, Booking> _booking;

        public GymHall()
        {
            _booking = new Dictionary<int, Booking>();
            ID = DateTime.Now.Year;
            Name = "Højen Gymnastiksal";
        }


        public override string ToString() {
            string Message = "Welcome to " + Name + " År " + ID + "You have booked the following team! : " + _booking;
            return Message;
        }

        //Metoder opgave 4

        public void RegisterBooking(Booking booking) {
           
            if (!_booking.ContainsKey(booking.ID))
            {
                _booking.Add(booking.ID, booking);
            }
        }

        public void PrintBookings() {
            foreach (Booking booking in _booking.Values)
            {
                Console.WriteLine(booking);
            }

        }
        public void RemoveBooking(Booking booking) {
            if (_booking.ContainsKey(booking.ID))
            {
                _booking.Remove(booking.ID);

            }
        }










    }
}
