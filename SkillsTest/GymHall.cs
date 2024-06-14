using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        //opgave 6
        public int TotalBookings
        {
            get
            {
                return _booking.Count;
            }
        }

        public GymHall()
        {
            //Levetiden for Booking objekterne er bundet til GymHall.
            //Når en GymHall bliver slettet, vil alle dets Booking objekter typisk også blive slettet. derfor komposition.
            _booking = new Dictionary<int, Booking>();
            ID = DateTime.Now.Year;
            Name = "Højen Gymnastiksal";
        }

        // opgave 6 test af Totalbookings
        public override string ToString() {
         
            return $"Welcome to {Name}! Year: {ID} Total Bookings: {TotalBookings}";
        }

        //Metoder opgave 4 CRUD

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



        ////Opgave 7
        //public bool Validate() {
        //    foreach (Booking booking in _booking.Values)
        //    {
        //        if (!booking.BookingDurationOK)
        //        {
        //            Console.WriteLine($"Booking ID {booking.ID} is invalid: Duration is longer than 2 hours.");
        //            return false;
        //        }

        //        if (booking.End < booking.Start)
        //        {
        //            Console.WriteLine($"Booking ID {booking.ID} is invalid: End time is before start time.");
        //            return false;
        //        }

        //        if (booking.Participants > 22)
        //        {
        //            Console.WriteLine($"Booking ID {booking.ID} is invalid: More than 22 participants.");
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Opgave 8
        public bool Validate() {
            foreach (Booking booking in _booking.Values)
            {
                try
                {
                    if (!booking.BookingDurationOK)
                    {
                        Console.WriteLine($"Booking ID {booking.ID} is invalid: Duration is longer than 2 hours.");
                    }
                    
                       
                }
                
                catch (Exception ex) {
                    Console.WriteLine($"Booking ID {booking.ID} is invalid: Duration is longer than 2 hours.");
                }
                try
                {
                    if (booking.End < booking.Start)
                    {
                        Console.WriteLine($"Booking ID {booking.ID} is invalid: End time is before start time.");
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Booking ID {booking.ID} is invalid: End time is before start time.");
                }
                try
                {
                    if (booking.Participants > 22)
                    {
                        Console.WriteLine($"Booking ID {booking.ID} is invalid: More than 22 participants.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Booking ID {booking.ID} is invalid: More than 22 participants.");
                }


            }
            return true;
        }




    }
}
