using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Entities
{
    public class SocialMediaPage : Notifier
    {
        public SocialMediaPage(string name) : base(name)
        {
        }
    }
}
