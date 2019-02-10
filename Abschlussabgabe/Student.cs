using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Student
    {
        public Student(string name, Studium studium, List<WPM> wpms, Timetable personalTimetable)
        {
            this.name = name;
            this.studium = studium;
            this.wpms = wpms;
            this.personalTimetable = personalTimetable;
        }
        public string name;
        public Studium studium;
        public List<WPM> wpms;
        public Timetable personalTimetable;
    }
}