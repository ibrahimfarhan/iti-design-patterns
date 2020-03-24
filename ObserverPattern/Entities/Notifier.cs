using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Entities
{
    public abstract class Notifier
    {
        public List<IFollower> Followers { get; set; }
        public string Name { get; set; }

        private string newContent;
        public string NewContent 
        { 
            get => newContent; 
            set 
            {
                if (newContent != value)
                {
                    newContent = value;
                    Console.WriteLine("{0} notified its followers\n", Name);
                    NotifyFollowers();
                }
            } 
        }


        public Notifier(string name)
        {
            Name = name;
            Followers = new List<IFollower>();
        }

        public void AddFollower(IFollower follower)
        {
            Followers.Add(follower);
        }

        public void RemoveFollower(IFollower follower)
        {
            Followers.Remove(follower);
        }

        public void NotifyFollowers()
        {
            foreach (IFollower follower in Followers)
            {
                follower.Update(this);
            }
        }
    }
}
