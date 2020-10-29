using DotNetCore.CAP;
using Services_2.EventSubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services_2.EventSubs
{
    public class SubscriberEventHandler : ISubscriberEvent, ICapSubscribe
    {
        [CapSubscribe("Service2.hello")]
        public void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
