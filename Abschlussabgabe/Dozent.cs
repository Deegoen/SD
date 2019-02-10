using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Dozent
    {
        public Dozent(string name, string prename, int[] blockedDays)
        {
            this.name = name;
            this.prename = prename;
            this.timetable = new Timetable();
            this.blockedDays = blockedDays;
        }

        public string name;
        public string prename;
        public Timetable timetable; 
        public int[] blockedDays;

        public bool isBlocked(int numberOfDay)
        {
            foreach(int blockedDay in blockedDays)
            {
                if(numberOfDay+1 == blockedDay){
                    return true;
                }
            }
            return false;
        }
        public bool hasTime(int numberOfDay, int block)
        {
            if(timetable.week[numberOfDay].blocksOnDay[block].course == null)
                return true;
            else return false;
        }
        
    }
}