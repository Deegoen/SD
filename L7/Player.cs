using System;

namespace L7
{

    public class Player
    {
        public int score;

        public void calculatescore(bool truth) //Methodennamen immer erster Buchstabe groß. jedes neue Wort mit einem Großbuchstaben beginnen
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
