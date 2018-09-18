using System;
using System.Collections.Generic;

namespace Patterns.Observable
{
    public abstract class Subject<T> where T: IObserver
    {
        private List<T> Observables = new List<T>();

        public void RegisterObservable(T observable)
        {
            Observables.Add(observable);
        }

        public void RemoveObservable(T observable)
        {
            Observables.Remove(observable);
        }

        public void NotifyAll(Event newEvent)
        {
            foreach(var observable in Observables)
            {
                try
                {
                    observable.Update(newEvent);
                }
                catch(Exception)
                {
                    //if some error occurs when notify, we choose do nothing
                }
            }
        }
    }
}
