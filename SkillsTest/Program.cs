namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args) {


            Console.WriteLine("Opgave 2.+opgave 6");

            // Test klassen ved at oprette nogle instanser af den i C# filen program.cs og skriv dem ud til 
            //konsollen med Console.WriteLine
            DateTime start1 = new DateTime(2024, 6, 23, 13, 00, 0);//21 - 06 - 2024 13:00:00
            DateTime end1 = new DateTime(2024, 6, 23, 14, 30, 0);
            Booking bk1 = new Booking(1, start1, end1, 12);

            DateTime start2 = new DateTime(2024, 6, 15, 15, 00, 0);
            DateTime end2 = new DateTime(2024, 6, 15, 17, 30, 0);
            Booking bk2 = new Booking(2, start2, end2, 10);

            DateTime start3 = new DateTime(2024, 6, 15, 18, 00, 0);
            DateTime end3 = new DateTime(2024, 6, 15, 20, 00, 0);
            Booking bk3 = new Booking(3, start3, end3, 8);

            Console.WriteLine(bk1);

            Console.WriteLine("");

            Console.WriteLine("Opgave 3 og 4.");

            GymHall gymDic = new GymHall();

            Console.WriteLine("Vores gymbooking er lavet " + gymDic.ID);
            Console.WriteLine();
            Console.WriteLine("Register reservationer og display dem:");
            gymDic.RegisterBooking(bk1);
            gymDic.RegisterBooking(bk2);
            gymDic.RegisterBooking(bk3);
            gymDic.PrintBookings();
         
            Console.WriteLine();
            Console.WriteLine("Fjern booking 1 og derefter display den nye liste");
            gymDic.RemoveBooking(bk1);
            gymDic.PrintBookings();

            Console.WriteLine("");
            Console.WriteLine("opgave 6: test af gymhal properties");
            Console.WriteLine(gymDic);








            Console.ReadKey();
        }
    }
}
