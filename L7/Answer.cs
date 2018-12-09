using System;

namespace L7
{
    class Answer
    {
        public string text;
        public bool isCorrect;

        public Answer(String text, Boolean isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }

    }
}