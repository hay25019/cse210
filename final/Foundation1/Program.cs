using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("How to kill a cow", "Farmer21", 24));
        videos[0].AddComment("Liker57", "I loved this video, very educational!");
        videos[0].AddComment("Hater90", "I hate blood.");
        videos[0].AddComment("Wierdoss", "THIS VIDO WUS VERY FUN! I LIK KILIN COWS!");

        videos.Add(new Video("The true story behind Trump's impeachment", "PolitialSavvy", 45));
        videos[1].AddComment("Liker57", "Wow, I had no idea that aliens were involed!");
        videos[1].AddComment("SkepticalViewer", "I highly doubt that aliens were in any way involed in the impeachment of president Trump.");
        videos[1].AddComment("Wierdoss", "NO HES RYT THE ALINS WER BEHIND IT ALL!");

        videos.Add(new Video("Why YouTube should be shut down", "SkepticalViewer", 10));
        videos[2].AddComment("Hater90", "I hate this video, it is wrong in every way.");
        videos[2].AddComment("Wierdoss", "YOU SAYD A LOT OF FANCY STUF I DIDNT UNDERSTAND, BUT YOUTUBE BELONGS HERE!");
        videos[2].AddComment("Liker57", "I'm sorry, but I actually agree with them.");
        videos[2].AddComment("YouTubeAdmin", "This video has been blocked for all of YouTube. We're sorry for the inconvenience, but please wait while we persecute the criminal that made this video.");
        videos[2].AddComment("Liker57", "Wait, they were a criminal?!?");
        videos[2].AddComment("YouTubeAdmin", "They are now...");

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}