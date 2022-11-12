using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    internal class Subscriber
    {
        public void IWantUseTimer(Clock clock)
        {
            clock.ClockEvent += OnClockEnded;
        }

        protected virtual void OnClockEnded(object? sender, string e)
        {
            Console.WriteLine(e);
        }
    }
}
