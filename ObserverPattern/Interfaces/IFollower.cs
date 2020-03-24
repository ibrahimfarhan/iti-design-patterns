using ObserverPattern.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IFollower
    {
        public void Update(Notifier notifier);
    }
}
