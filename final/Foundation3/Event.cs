using System.Net.Sockets;

abstract public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _eventType;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_time} at {_address}");
    }
    public virtual void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_time} at {_address}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"Type of event: {_eventType}");
        Console.WriteLine($"Title: {_title}, date: {_date}");
    }
}