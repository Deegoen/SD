using System;

namespace L7
{
    class QuizFree : Quizelement
    {
        public string answer;
        public QuizFree(String question, string answer)
        {
            this.question = question;
            this.answer = answer;
            this.callToAction = "Tippen Sie die korrekte Antwort ein:";
        }
        public override void show()
        {
            Console.WriteLine(question);
            Console.WriteLine(callToAction);
        }
        public override bool isAnswerCorrect(string choice)
        {
            if (choice == answer)
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