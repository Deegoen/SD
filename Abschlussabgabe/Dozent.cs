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
            this.blockedDays = blockedDays;
            this.timetable = new Timetable();
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
            if(timetable.week[numberOfDay].blocksPerDay[block].course == null)
                return true;
            else return false;
        }
        
    }
}