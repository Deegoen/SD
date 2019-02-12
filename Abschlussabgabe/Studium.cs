using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Studium
    {
        public Studium(string name, int students)
        {
            this.name = name;
            this.students = students;
            this.timetable = new Timetable();
        }

        public string name;

        public int students;

        public Timetable timetable;

        public bool HasTime(int numberOfDay, int block)
        {
            if (timetable.week[numberOfDay].blocksPerDay[block].course == null)
                return true;
            else return false;
        }

        public void PossibleWpms(Generator generator)
        {
            List<WPM> PossibleWpms = new List<WPM>();
            if (generator.timetablesAreCalculated == true)
            {
                foreach (WPM wpm in generator.allWpms)
                {
                    //hat Studiengang an diesem Zeitpunkt Zeit für WPM
                    if (timetable.week[wpm.day - 1].blocksPerDay[wpm.block - 1].course == null)
                        PossibleWpms.Add(wpm);
                }
                Console.WriteLine();
                Console.WriteLine("Mögliche WPMs an deren Terminen du Zeit hast:");
                Console.WriteLine();
                foreach (WPM wpm in PossibleWpms)
                {
                    Console.WriteLine(wpm.description);
                }
            }
            else Console.WriteLine("Stundenplan noch nicht berechnet");



        }
    }
}