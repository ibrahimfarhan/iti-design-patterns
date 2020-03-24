using ObserverPattern.Entities;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialMediaPage page1 = new SocialMediaPage("page1");
            SocialMediaPage page2 = new SocialMediaPage("page2");

            page1.AddFollower(new Follower("follower1OfPage1"));
            page1.AddFollower(new Follower("follower2OfPage1"));

            page2.AddFollower(new Follower("follower1OfPage2"));
            page2.AddFollower(new Follower("follower2OfPage2"));

            page1.NewContent = "new content of page 1";
            page2.NewContent = "new content of page 2";

            Console.ReadLine();
        }
    }
}
