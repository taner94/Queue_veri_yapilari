using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    public interface IQueue
    {
        void Insert(object o);
        object Remove();
        object Peek();
        Boolean IsEmpty();
    }
}
