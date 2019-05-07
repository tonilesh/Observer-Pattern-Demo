using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Observer
{
    public abstract class Publisher<T>
    {
        protected List<ISubscriber<T>> subscribers = new List<ISubscriber<T>>();

        public void Subscribe(ISubscriber<T> subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber<T> subscriber)
        {
            if (subscribers.Contains(subscriber))
                subscribers.Remove(subscriber);
        }

        protected void Notify(T state)
        {
            foreach (ISubscriber<T> subscriber in subscribers)
                subscriber.GetUpdate(state);

        }
    }
}
