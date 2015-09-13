using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
    }
}
