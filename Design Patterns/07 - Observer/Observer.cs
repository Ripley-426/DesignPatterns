using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public interface IObserver
    {
        void Update();
    }

    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
    
    public class Chef : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }

        public void Cook()
        {
            Console.WriteLine("Starting to cook!");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Finished cooking!");
            Notify();
        }
    }
    
    public class HungryPerson : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Yummy!");
        }
    }
}