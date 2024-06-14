namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args) {


            Console.WriteLine("Opgave 2.");

            // Test klassen ved at oprette nogle instanser af den i C# filen program.cs og skriv dem ud til 
            //konsollen med Console.WriteLine
            DateTime start1 = new DateTime(2024, 6, 15, 12, 30, 0);
            DateTime end1 = new DateTime(2024, 6, 15, 14, 30, 0);
            Booking bk1 = new Booking(1, start1, end1, 12);

            Console.WriteLine(bk1);

            Console.WriteLine("");

            Console.WriteLine("Opgave 3.");












            Console.ReadKey();
        }
    }
}
