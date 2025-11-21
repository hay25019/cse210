using System;

class Program
{
    static void Main(string[] args)
    {
        /* I added more scriptures, with it randomly selecting from them, and I made it so that it only hides words that aren't already hidden. */
        List<string> references = ["Proverbs 3:5-6", "John 14:15", "Moroni 7:6-8", "Helaman 12:7"];
        List<string> scriptures = ["Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.", "If ye love Me, keep My commandments.", "For behold, God hath said a man being evil cannot do that which is good; for if he offereth a gift, or prayeth unto God, except he shall do it with real intent it profiteth him nothing. For behold, it is not counted unto him for righteousness. For behold, if a man being evil giveth a gift, he doeth it grudgingly; wherefore it is counted unto him the same as if he had retained the gift; wherefore he is counted evil before God.", "O how great is the nothingness of the children of men; yea, even they are less than the dust of the earth."];
        Random random = new Random();
        int index = random.Next(0, scriptures.Count);
        Scripture scripture = new Scripture(references[index], scriptures[index]);
        while (true)
        {
            scripture.DisplayScripture();
            if (scripture.CheckIsVisible() == false)
            {
                break;
            }
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string answer = Console.ReadLine().ToLower();
            if (answer == "quit")
            {
                break;
            }
            else
            {
                scripture.PickRandomWord();
            }
        }
    }
}