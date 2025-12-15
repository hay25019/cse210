public class ReceptionEvent : Event
{
    private string _email;
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public override void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"RSVP at {_email}");
        Console.WriteLine($"{_time} at {_address}");
    }
}