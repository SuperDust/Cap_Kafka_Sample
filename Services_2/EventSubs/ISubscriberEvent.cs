using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services_2.EventSubs
{
    public interface ISubscriberEvent
    {
        public void Hello(string msg);
    }
}
