using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClock
{
    class AlarmClock //public?
    {
        //Fälten.
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;
        private string p;

        /// <summary>
        /// Fälternas egenskaper.
        /// </summary>
        public int AlarmHour
        {
            get { return _alarmHour; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");
                }
                _alarmHour = value;
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23.\n");
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("No! No! No!");
                }
                _minute = value;
            }
        }

        /// <summary>
        /// Kontruktorer.
        /// </summary>
        public AlarmClock()
            : this(0, 0)
        {

        }

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {

            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;

        }


        public AlarmClock(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        /// <summary>
        /// Publik metod som anropas för att få klockan att gå en minut. Om den nya tiden överensstämmer med
        /// alarmtiden ska metoden returnera true, annars false.
        /// </summary>
        /// <returns></returns>
        public bool TickTock()
        {
            if (Minute < 59)
            {
                Minute++;
            }
            else
            {
                Minute = 0;
                if (Hour < 23)
                {
                    Hour++;
                }
                else
                {
                    Hour = 0;
                }
            }

            return AlarmHour == Hour && AlarmMinute == Minute;

            //if (Minute == 60 && Hour == 23)
            //{
            //    Hour = 0;
            //    Minute = 0;
            //}

            //if (Minute == 60 && Hour != 23)
            //{
            //    Minute = 0;
            //    Hour++;
            //}

            //if (AlarmHour == Hour && AlarmMinute == Minute)
            //{
            //    return true;
            //}

            //return false;
        }

        /// <summary>
        /// Publik metod som har som uppgift att returnera en sträng representerande värdet av en instans av klassen AlarmClock./
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0,2}:{1:00} ({2}:{3:00})", Hour, Minute, AlarmHour, AlarmMinute);

            //Deklarerar nya lokala variabel av typen "string" .
            //"Int" fälten converteras till "string" med hjälp av "ToString" metod.
            /*-------------------------------------------------------------------------------------------------------
             -------------------------------------------------------------------------------------------------------*/
            //sidan 65.
            /*string hours = Hour.ToString();
            string alarmHours = AlarmHour.ToString();
            string minutes = Minute.ToString();
            string alarmMinutes = AlarmMinute.ToString();
            /*string time= hours +":"+ minutes;
            string alarmTime = alarmHours + ":" + alarmMinutes;
            //return String.Format("{0, 8:0}:{1} ({2}:{3}) BEEP! BEEP! BEEP! BEEP!", hours, minutes, alarmHours, alarmMinutes);
            return String.Format("{0, 8:0}:{1} ({2}:{3})", hours, minutes, alarmHours, alarmMinutes);*/

            //string time = Hour.ToString() + ":" + Minute.ToString();
            //string alarmTime = AlarmHour.ToString() + ":" + AlarmMinute.ToString();

            //if (Hour < 10)
            //{
            //    time = "" + Hour + ":" + Minute;
            //}

            //if (AlarmHour < 10)
            //{
            //    alarmTime = "" + AlarmHour + ":" + AlarmMinute;
            //}

            //if (Minute < 10)
            //{
            //    time = Hour + ":" + "0" + Minute;
            //}

            //if (AlarmMinute < 10)
            //{
            //    alarmTime = AlarmHour + ":" + "0" + AlarmMinute;
            //}

            //if (time == alarmTime)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Beep();

            //    }
            //    //Console.BackgroundColor = ConsoleColor.Black;
            //    //Console.ForegroundColor = ConsoleColor.White;
            //    return String.Format("{0, 8:0}  ({0}) BEEP! BEEP! BEEP! BEEP!", time, alarmTime);
            //}

            //return String.Format("{0, 8:0}  ({1})", time, alarmTime);

        }

    }
}