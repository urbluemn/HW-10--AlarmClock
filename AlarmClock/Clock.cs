using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    
    internal class Clock
    {
        public event EventHandler<string>? ClockEvent;
        public void SetTimer(int timer)
        {
            for(int i = timer; i>0; i--)
            {
                
                ClockEvent?.Invoke(this, $"Time left: {i}");
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.Clear();
            ClockEvent?.Invoke(this, $"Time's up!");
        }
        

        //protected virtual void OnClockEnded(object source, string str)
        //{
        //    if(ClockEvent!=null)
        //    ClockEvent.Invoke(this, String.Empty);
        //}
    }
}
