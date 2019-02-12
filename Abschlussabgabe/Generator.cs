using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Generator
    {
        public Generator()
        {
            this.allRooms = new List<Room>();
            this.allStudys = new List<Studium>();
            this.allDozenten = new List<Dozent>();
            this.allCourses = new List<Course>();
            this.allWpms = new List<WPM>();
        }

        public List<Room> allRooms;

        public List<Studium> allStudys;

        public List<Dozent> allDozenten;

        public List<Course> allCourses;

        public List<WPM> allWpms;

        public bool timetablesAreCalculated;



        public Studium GetByName(string name)
        {
            foreach (Studium studium in allStudys)
            {
                if (studium.name.Equals(name))
                    return studium;
            }
            return null;
        }

        public Dozent GetByNameDozent(string prename)
        {
            foreach (Dozent dozent in allDozenten)
            {
                if (dozent.prename.Equals(prename))
                    return dozent;
            }
            return null;
        }


        // public void createEmptyTimetable()
        // {
        //     foreach(Studium studium in allStudys)
        //     {
        //         studium.timetable = new Timetable();
        //     }

        //     foreach(Dozent dozent in allDozenten)
        //     {
        //         dozent.timetable = new Timetable();
        //     }

        //     foreach(Room room in allRooms)
        //     {
        //         room.timetable = new Timetable();
        //     }
        // }

        public void FillBlock(int block)
        {
            foreach (Room room in allRooms)
            {
                foreach (Day day in room.timetable.week)
                {

                    if (allCourses.Count == 0)
                        return;

                    Course course = GetPossibleCourse(room, day.numberOfDay - 1, block);

                    if (course == null)
                        continue;
                    // Course wird für alle Timetables gesetzt, wenn passend
                    course.studium.timetable.week[day.numberOfDay - 1].blocksPerDay[block].course = course;
                    room.timetable.week[day.numberOfDay - 1].blocksPerDay[block].course = course;
                    course.dozent.timetable.week[day.numberOfDay - 1].blocksPerDay[block].course = course;

                    // Gesetzter Kurs wird aus Liste allCourses entfernt
                    allCourses.Remove(course);
                }
            }
        }

        private Course GetPossibleCourse(Room room, int numberOfDay, int block)
        {
            //temporäre Liste
            List<Course> tempAllCourses = new List<Course>();
            foreach (Course copyCourse in allCourses)
                tempAllCourses.Add(copyCourse);

            int i = 0;
            Course course = null;
            while (i != 1)
            {   // ist in Liste Inhalt
                if ((tempAllCourses == null) || (tempAllCourses.Count == 0))
                    return null;

                course = tempAllCourses[0];
                //wird überprüft ob Bedingungen passen, Prof Zeit, Studiengang Zeit, Raum Eigenschaften, wenn alles passt wird Course gesetzt
                if (!course.dozent.IsBlocked(numberOfDay) && course.dozent.HasTime(numberOfDay, block) && course.studium.HasTime(numberOfDay, block) && room.CompareWithCourse(course))
                {
                    i = 1;
                }
                else
                {
                    tempAllCourses.Remove(course);
                    course = null;
                }
            }
            return course;
        }

    }
}