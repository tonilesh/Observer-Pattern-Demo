using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Observer
{
    public interface ISubscriber<T>
    {
        void GetUpdate(T state);
    }
}
