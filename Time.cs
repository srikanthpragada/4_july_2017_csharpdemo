using System;

namespace csharpdemo
{
    class Time : IComparable<Time>
    {
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }

        public int TotalSeconds
        {
            get
            {
                return Hours * 3600 + Mins * 60 + Secs;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}", Hours, Mins, Secs);
        }

        public override bool Equals(object obj)
        {
            Time other = obj as Time;
            return this.TotalSeconds == other.TotalSeconds;
        }

        public int CompareTo(Time other)
        {
            return this.TotalSeconds - other.TotalSeconds;
        }
    }
    class TestTime
    {
        public static void Main()
        {
            Time[] times = { new Time { Hours = 10, Mins = 10, Secs = 10 },
                             new Time { Hours = 10, Mins = 20, Secs = 30 },
                             new Time { Hours = 1, Mins = 2, Secs = 3 }
                           };

            Array.Sort(times);

            foreach (Time t in times)
                Console.WriteLine(t.ToString());

        }
    }
}

