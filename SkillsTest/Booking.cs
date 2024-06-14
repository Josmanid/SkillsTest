using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    internal class Booking
    {

        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Participants { get; set; }



        public Booking(int id, DateTime start, DateTime end, int participants)
        {
            ID = id;
            Start = start;
            End = end;
            Participants = participants;
        }


        public override string ToString() {
            string message = "Your booking Id is: " + ID + " You booking starts at: " + Start+" And ends at: "+End+" with the following number of participants: "+Participants;
            return message;
        }


    }
}
