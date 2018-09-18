
using System.Collections.Generic;
using System.Linq;


namespace Patterns.Observable
{
    public class QueueManager : Subject<IObserver>
    {
        private List<Data> Data = new List<Data>();

        public void AddElement(Data data)
        {
            Data.Add(data);
            NotifyAll(new Event { Type = EventType.ItemAdded, Data = data });
        }

        public void RemoveElement(Data data)
        {
            var elementToBeRemoved = Data.FirstOrDefault(_ => _.Name == data.Name);
            if (elementToBeRemoved == null)
                return;
            Data.Remove(elementToBeRemoved);
            NotifyAll(new Event { Type = EventType.ItemRemoved, Data = elementToBeRemoved });
        }
    }
}
