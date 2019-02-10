using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Settings
    {
        public Settings(int[] orderBlocks, int maxBlocksPerDay, int minBlocksPerDay, int maxBlocksWithoutBreak)
        {
            this.orderBlocks = orderBlocks;
            this.maxBlocksPerDay = maxBlocksPerDay;
            this.minBlocksPerDay = minBlocksPerDay;
            this.maxBlocksWithoutBreak = maxBlocksWithoutBreak;

        }

        public int[] orderBlocks;
        public int maxBlocksPerDay;
        public int minBlocksPerDay;
        public int maxBlocksWithoutBreak;
    }
}