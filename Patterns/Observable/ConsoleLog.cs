using System;

namespace Patterns.Observable
{
    public class ConsoleLog : IObserver
    {
        public void Update(Event newEvent)
        {
            if(newEvent.Type == EventType.ItemAdded)
                Console.WriteLine("Added new Item, name is: " + newEvent.Data.Name );
            else
                Console.WriteLine("Removed Item, name is: " + newEvent.Data.Name);
        }
    }
}
