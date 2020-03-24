using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Entities
{
    public class Follower : IFollower
    {
        public string Name { get; set; }
        public string DisplayedContent { get; set; }

        public Follower(string name)
        {
            Name = name;
        }

        public void Update(Notifier notifier)
        {
            DisplayedContent = notifier.NewContent;
            Console.WriteLine("{0} updated its content with {1}\n", Name, DisplayedContent);
        }
    }
}
