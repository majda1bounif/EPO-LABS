using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_8
{
    public class Subject : ISubject
    {
        private int count = 0;
        private int sum = 0;
        private string name;
        private float basePrice;
        private float currentPrice;

        private List<Observer> Observers = new List<Observer>();
        public Subject(string name, float basePrice)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.currentPrice = basePrice;
        }
        public float Price
        {
            get
            {
                return basePrice;
            }
            set
            {
                basePrice = value;
                if (value > currentPrice)
                {
                    //notifyObservers();
                }


            }
        }
        public void registerObserver(Observer observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        public int CountObserver(Observer observer)
        {
            return Observers.Count();
        }
        public void unregisterObserver(Observer observer)
        {
            Observers.Remove(observer);
            
        }
        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.update(this);
            }
        }

        public  string Name
        {
            get { return name; }
        }

        public float discount
        {
            get { return (basePrice - currentPrice) * 100 / basePrice; }
        }
        public float CurrentPrice
        {
            get { return currentPrice; }
        }
    }
}


