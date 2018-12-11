using System;

namespace L7
{

    public class Player
    {
        public int score;

        public void CalculateScore(bool truth)
        {
            if (truth == true)
            {
                score = score + 1;
            }
            else
            {
                score = score - 1;
            }
        }
    }
}