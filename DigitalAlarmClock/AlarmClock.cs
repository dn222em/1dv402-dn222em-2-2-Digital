using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClock
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        public int AlarmHour
        {
            get { return _alarmHour; }

            private set
            {
                if (value < 0 || value > 23 )
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }

        public int AlarmMinute 
        {
            get { return _alarmMinute; }

            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }

            private set
            {
                if (value < 0 || value >23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }

            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        public AlarmClock()
        {
            //AlarmClock(int hour, int minute);
        }

        public AlarmClock(int hour, int minute)
        {
            

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _alarmHour = AlarmHour;
            _hour = Hour;
            _alarmMinute = AlarmMinute;
            _minute = Minute;
        }

       /* public bool TicTock()
        {
            if ()
         {
         return true;
         }
            
             return false;
        }

        public string Tostring()
        {

        }*/

        
    }
}
