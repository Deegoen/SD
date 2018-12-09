using System;

namespace L7
{
    class QuizMultiple : Quizelement
    {
        public QuizMultiple(String question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
            this.callToAction = "Tippen Sie die richtigen Antworten ein, bitte trennen Sie die Antworten durch: \",\" ";
        }
        public override void show()
        {
            Console.WriteLine(question);
            for (int i = 0; i < this.answers.Length; i++)
            {
                int questionNumber = i + 1;
                Console.WriteLine(questionNumber + ") " + this.answers[i].text);
            }
            Console.WriteLine(callToAction);
        }
        public override bool isAnswerCorrect(string choice)
        {
            string[] parts = Array.ConvertAll(choice.Split(','), p => p.Trim());
            int[] pickedAnswers = Array.ConvertAll(parts, int.Parse);

            int numberOfCorrectAnswers = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].isCorrect == true)
                {
                    numberOfCorrectAnswers++;
                }
            }

            if (numberOfCorrectAnswers != pickedAnswers.Length)
            {
                Console.WriteLine("Sie haben zu viele oder zu wenige Antworten gegeben!");
                return false;
            }
            else
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    try
                    {
                        if (answers[pickedAnswers[i] - 1].isCorrect == false)
                        {
                            Console.WriteLine("Eine der Antworten war falsch!");
                            return false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Möglicherweise existiert eine Ihrer Antworten nicht!");
                    }
                }
            }
            return true;
        }
    }
}