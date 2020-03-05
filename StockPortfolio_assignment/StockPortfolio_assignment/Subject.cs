using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio_assignment
{
    public abstract class Subject<T>
    {
        protected readonly List<IObserver<T>> observers = new List<IObserver<T>>();

        public void Attach(IObserver<T> observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver<T> observer)
        {
            observers.Remove(observer);
        }
    }
}
