using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Room
    {
        public Room(string name, int seats, List<Conditions> roomConditions)
        {
            this.name = name;
            this.seats = seats;
            this.roomConditions = roomConditions;
            this.timetable = new Timetable();
        }
        public string name;
        public int seats;
        public List<Conditions> roomConditions;
        public Timetable timetable;

        public bool compareWithCourse(Course course)
        {

            foreach(Conditions condition in roomConditions)
            {
                if(course.conditions.Contains(condition))
                    continue;
                else return false;
            }

            foreach(Conditions condition in course.conditions)
            {
                if(roomConditions.Contains(condition))
                    continue;
                else return false;
            }


            if(this.isRoomBigEnough(course) == false)
                return false;

            return true;
        }

        public bool isRoomBigEnough(Course course){
            if(seats >= course.studium.students)
                return true;
            else return false;
        }

    }
}