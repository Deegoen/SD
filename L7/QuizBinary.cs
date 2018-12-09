using System;

namespace L7
{
    class QuizBinary : Quizelement
    {
        public bool isTrue;
        public QuizBinary(String question, bool isTrue)
        {
            this.question = question;
            this.isTrue = isTrue;
            this.callToAction = "Tippen Sie ja oder nein?(j/n):";

        }
        public override void show()
        {
            Console.WriteLine(question);
            Console.WriteLine(callToAction);
        }
        public override bool isAnswerCorrect(string choice)
        {
            bool theAnswer = (choice == "j");
            if (theAnswer == isTrue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}