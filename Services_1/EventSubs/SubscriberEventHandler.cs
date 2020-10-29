using DotNetCore.CAP;
using Services_1.EventSubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services_1.EventSubs
{
    public class SubscriberEventHandler : ISubscriberEvent, ICapSubscribe
    {
        [CapSubscribe("Service1.hello")]
        public void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
