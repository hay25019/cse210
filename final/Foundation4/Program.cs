using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("15 Dec 2025", 30, 2.5));
        activities.Add(new Cycling("15 Dec 2025", 30, 7));
        activities.Add(new Swimming("15 Dec 2025", 120, 200));

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}