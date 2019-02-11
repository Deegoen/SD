using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class WPM : Course
    {
        public WPM(string name, string description, int day, int block, Dozent dozent, List<Conditions> conditions)
        {
            this.name = name;
            this.description = description;
            this.day = day;
            this.block = block;
            this.dozent = dozent;
            this.conditions = conditions; 
        }
        public int day;
        public int block;
    }
}