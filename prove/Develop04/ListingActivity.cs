public class ListingActivity : Activity
{
    private string _name = "Listing Activity";
    private string _description = "This activity will help you reflect on the food things in your life by having you list as many things as you can in a certain area.";
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengrhs of yours?", "Who are people that you habe helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

    public ListingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        DisplayStart(_name, _description);
    }
}