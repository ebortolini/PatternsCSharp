using Patterns.Observable;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueManager = new QueueManager();
            queueManager.RegisterObservable(new ConsoleLog());
            queueManager.AddElement(new Data { Name = "First Event" });
            queueManager.AddElement(new Data { Name = "Second Event" });
            queueManager.RemoveElement(new Data { Name = "First Event" });
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
