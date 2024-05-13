namespace day9s_tasks
{
    class Clock
    {
        int _hour;
        int _minute;
        int _second;

        public int hour{
            get { return _hour; }
            set { 
                if (value > 24 || value < 0)
                    Console.WriteLine("invalid input");
                else
                    _hour = value;
            }
        }

        public int minute {
            get { return _minute; }
            set
            {
                if (value > 60 || value < 0)
                    Console.WriteLine("invalid input");
                else
                    _minute = value;
            }
        }

        public int second
        {
            get { return _second; }
            set
            {
                if (value > 60 || value < 0)
                    Console.WriteLine("invalid input");
                else
                    _second = value;
            }
        }

        public void AddSecond()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                AddMinute();
            }
        }

        public void AddMinute()
        {
            minute++;
            if (minute == 60)
            {
                minute = 0;
                AdddHour();
            }
        }

        public void AdddHour()
        {
            hour++;
            if (hour == 24)
            {
                hour = 0;
            }
        }

        public void SubtractSecond()
        {
            second--;
            if (second == -1)
            {
                second = 59;
                SubtractMinute();
            }
        }

        public void SubtractMinute()
        {
            minute--;
            if (minute == -1)
            {
                minute = 59;
                SubtractHour();
            }
        }

        public void SubtractHour()
        {
            hour--;
            if (hour == -1)
            {
                hour = 23;
            }
        }

        public void GetCurrentTime() {
            Console.WriteLine($"{_hour}:{_minute}:{_second}");
        }

    }
}
