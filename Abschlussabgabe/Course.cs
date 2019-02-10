using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Course
    {

        public Course(string name, string description, Dozent dozent, Studium studium, List<Conditions> conditions)
        {
            this.name = name;
            this.description = description;
            this.dozent = dozent;
            this.studium = studium;
            this.conditions = conditions;

        }

        public Course(){}

        public string name;
        public string description;
        public Dozent dozent;
        public Studium studium;
        public List<Conditions> conditions; 
    }
}