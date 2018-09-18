using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observable
{
    public interface IObserver
    {
        void Update(Event newEvent);
        
    }
}
