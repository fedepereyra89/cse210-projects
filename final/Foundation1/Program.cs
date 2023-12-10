using System;

namespace Foundation1
{
    class Program
    {
        static void Main()
        {
            List<Video> videos = new List<Video>();
            Video video1 = new Video("DIY Home Decor", "Me", 1560);
            Video video2 = new Video("Funny Cat Compilation", "My Sister", 300);
            Video video3 = new Video("Mind-Blowing Magic Tricks", "Someone Else", 850);

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            Comment comment1 = new Comment("HomeCraftQueen", "Awesome DIY project! Loved how simple and affordable it was to create such a beautiful piece. Can't wait to try it myself!");
            Comment comment2 = new Comment("CreativeCorner", "This DIY home decor idea is genius! I've been looking for a unique way to spruce up my space, and this tutorial is just what I needed. Thanks for sharing!");
            Comment comment3 = new Comment("DIYEnthusiast89", "Such a creative DIY project! I'm amazed at how you transformed ordinary materials into a stunning home decor piece. Definitely adding this to my to-do list!");
            Comment comment4 = new Comment("FelineFanatic", "OMG, this cat compilation is everything! I can't stop laughing at their hilarious antics. Cats really know how to bring joy to our lives!");
            Comment comment5 = new Comment("PurrfectLaughs", "These cats are comedy gold! Their mischievous behavior and playful antics are too funny to handle. Thanks for putting a smile on my face!");
            Comment comment6 = new Comment("WhiskerWonderland", "This compilation is purr-fectly hilarious! It's amazing how cats can effortlessly make us laugh with their adorable and quirky behavior. Thank you for brightening my day!");
            Comment comment7 = new Comment("MagicEnthusiast95", "Wow, these magic tricks blew my mind! I'm still trying to figure out how the magician pulled off those mind-boggling illusions. Such incredible talent!");
            Comment comment8 = new Comment("WonderWizardry", "Unbelievable magic tricks! My jaw dropped at every twist and turn. This magician's skill and showmanship are absolutely captivating. Bravo!");
            Comment comment9 = new Comment("EnigmaMagic", "Mesmerizing performance! These mind-blowing magic tricks had me on the edge of my seat. I couldn't believe my eyes. This magician is a true master of illusions!");
            
            video1.AddComment(comment1);
            video1.AddComment(comment2);
            video1.AddComment(comment3);
            video2.AddComment(comment4);
            video2.AddComment(comment5);
            video2.AddComment(comment6);
            video3.AddComment(comment7);
            video3.AddComment(comment8);
            video3.AddComment(comment9);

            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video._title}\nAuthor: {video._author}\nLength in Seconds: {video._lengthInSeconds}\nNumber of Comments: {video.GetNumberOfComments()}");
                foreach (Comment comment in video._comments)
                {
                    Console.WriteLine($"User: {comment._commentor}\nComment: {comment._text}");
                }
            }
        }
    }
}