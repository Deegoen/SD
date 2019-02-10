using System;

namespace Abschlussabgabe
{
    class Timetable
    {
        public Timetable()
        {
            this.week = new Day[5] { new Day(1), new Day(2), new Day(3), new Day(4), new Day(5) };
        }
        public Day[] week;

        public void show()
        {
            for (int i = 0; i <= 5; i++)
            {
                foreach (Day day in week)
                {
                    if (day.blocksOnDay[i].course != null)
                        Console.Write("{0, -15}", day.blocksOnDay[i].course.name);
                    else Console.Write("{0, -15}", "Frei");
                }
                Console.WriteLine();
            }
        }
    }

}