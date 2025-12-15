using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.Clear();
        List<Event> events = new List<Event>();
        LectureEvent lecture = new LectureEvent("Why not to let your kids not have phones", "A famous speaker will explain...something about phones.", "4/1/2020", "7:00 AM", new Address("1805 New York Avenue", "Phoenix", "Arizona", "United States"), "Tot A. Ly Reel", 50);
        ReceptionEvent reception = new ReceptionEvent("Wedding reception for two random people", "We found some random people who wanted a party, but the only stuff we had on hand was stuff for a wedding reception, so we just used that.", "4/1/2020", "10:00 AM", new Address("1806 New York Avenue", "Phoenix", "Arizona", "United States"), "totalyrealemail@notfake.com");
        OutdoorEvent outdoor = new OutdoorEvent("Lawn Games!", "Lawn Games!", "3/30/2020", "11:59 PM", new Address("1804 New York Avenue", "Phoenix", "Arizona", "United States"), "Thunderstorms the whole time.");
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        foreach (Event @event in events)
        {
            @event.StandardDetails();
            Console.WriteLine();
            @event.FullDetails();
            Console.WriteLine();
            @event.ShortDescription();
            Console.WriteLine();
        }
    }
}