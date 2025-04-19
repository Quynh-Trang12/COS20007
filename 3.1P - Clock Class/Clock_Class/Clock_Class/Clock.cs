using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Class
{
    public class Clock
    {
        private Counter _hour;
        private Counter _minute;
        private Counter _second;

        public Clock()
        {
            _hour = new Counter("hour");
            _minute = new Counter("minute");
            _second = new Counter("second");
        }

        public void Tick()
        {
            if (_second.Ticks < 59)
            {
                _second.Increment();   
            }
            else
            {
                _second.Reset();

                if (_minute.Ticks < 59)
                {
                    _minute.Increment();
                }
                else
                {
                    _second.Reset();
                    _minute.Reset();

                    if (_hour.Ticks <23 )
                    {
                        _hour.Increment();                      
                    }
                    else
                    {
                        this.Reset();
                    }      
                }
            }           
        }

        public void Reset()
        {
            _second.Reset();
            _minute.Reset();
            _hour.Reset();
        }

        public string getTime()
        {
            return $"{ _hour.Ticks:D2}:{_minute.Ticks:D2}:{_second.Ticks:D2}";
        }
    }
}
