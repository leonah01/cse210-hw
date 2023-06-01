using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("258 Windsor St", "Carlifonia", "CA", "74320");
        Address address2 = new Address("326 Brenthood Rd", "Seattle", "ST", "15008");
        Address address3 = new Address("920 Wilson Rd", "New York", "NY", "22076");

        Event[] events = {
            new LectureEvent("Coding Active", "Learn about how to code in different languages", new DateTime(2023, 3, 11), new TimeSpan(9), address1, "Susan Miller", 50),
            new ReceptionEvent("30 years Anniversary Party", "Help us celebrate our success.", new DateTime(2023, 4, 15), new TimeSpan(18), address2, "Email from codes@Greatcompany.com"),
            new OutdoorGatheringEvent("Family Gathering", "Come and let us celebte the family reunion in style.", new DateTime(2023, 5, 25, 10, 0, 0), TimeSpan.FromHours(2), address3, "STAY SAFE AND HaVE FUN!")
        };

        // Call each method to generate the marketing messages and output their results to the screen

        Console.WriteLine("\nAddress:");
        Console.WriteLine("Event 1: " + address1.GetFullAddress());
        Console.WriteLine("Event 2: " + address2.GetFullAddress());
        Console.WriteLine("Event 3: " + address3.GetFullAddress());

        foreach (Event ev in events)
        {
            Console.WriteLine($"\n{ev.GetType().Name}:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(ev.GetShortDescription());
        }
    }
}