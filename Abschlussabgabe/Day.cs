using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Day
    {
        public Day(int numberOfDay)
        {
            this.numberOfDay = numberOfDay;
            this.blocksPerDay = new Block[6]{new Block(),new Block(),new Block(),new Block(),new Block(),new Block(),};
        }
        public Block[] blocksPerDay;
        public int numberOfDay;

    }
}