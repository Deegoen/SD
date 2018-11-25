using System;
using System.Collections.Generic;

namespace L6
{
    class Program
    {

        public static List<Quizelement> listWithAllQuestionsAndAnswers = new List<Quizelement>();
        public static Player player = new Player();

        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich Willkommen! Mit welchem Namen möchten Sie spielen?");
            player.playerName = Console.ReadLine();
            player.score = 0;
            game();
        }

        public static void game()
        {
            Quizelement quiz = CreationOfQuestionAndAnswers();
            Console.WriteLine("Was willst du tun?");
            Console.WriteLine(player.playerName + "'s Score is: " + player.score);
            Console.WriteLine("1. Fragen beantworten   2. Fragen erstellen   3. Beenden");
            string mode = Console.ReadLine();

            switch (mode)
            {
                case "1":
                    quiz.show();
                    Console.WriteLine("Welche Nummer ist richtig ?");
                    int userInput = Int32.Parse(Console.ReadLine());
                    quiz.IsAnswerCorrect(userInput, player);
                    game();
                    break;
                case "2":
                    CreateOwnQuestions();
                    game();
                    break;
                default:
                    Console.WriteLine("Du hast  " + player.score + " Punkte erreicht. Super Wahnsinn");
                    break;
            }

        }

        public static Quizelement CreationOfQuestionAndAnswers()
        {

            Quizelement quiz = new Quizelement();
            quiz.question = "Wer war der erste Bundeskanzler der BRD ?";
            quiz.answers = new Answer[4];
            quiz.answers[0] = new Answer { text = "Barack Obama", truth = false };
            quiz.answers[1] = new Answer { text = "Helmut Kohl", truth = false };
            quiz.answers[2] = new Answer { text = "Konrad Adenauer", truth = true };
            quiz.answers[3] = new Answer { text = "Angela Merkel", truth = false };


            Quizelement quiz2 = new Quizelement();
            quiz2.question = "Wer ist amtierender deutscher Meister?";
            quiz2.answers = new Answer[6];
            quiz2.answers[0] = new Answer { text = "Borussia Dortmund", truth = false };
            quiz2.answers[1] = new Answer { text = "Hoffenheim", truth = false };
            quiz2.answers[2] = new Answer { text = "Hertha BSC", truth = false };
            quiz2.answers[3] = new Answer { text = "FC Bayern München", truth = true };
            quiz2.answers[4] = new Answer { text = "Mainz 05", truth = false };
            quiz2.answers[5] = new Answer { text = "RB Leipzig", truth = false };

            listWithAllQuestionsAndAnswers.Add(quiz);

            listWithAllQuestionsAndAnswers.Add(quiz2);

            Quizelement questionToDisplay = GetRandomQuestion(listWithAllQuestionsAndAnswers);

            return questionToDisplay;

        }

        public static Quizelement GetRandomQuestion(List<Quizelement> _listWithAllQuestionsAndAnswers)
        {

            Random rnd = new Random();
            int randomNumber = rnd.Next(_listWithAllQuestionsAndAnswers.Count);
            Quizelement randomQuestion = _listWithAllQuestionsAndAnswers[randomNumber];

            return randomQuestion;
        }

        public static void CreateOwnQuestions()
        {
            Quizelement newQuiz = new Quizelement();

            Console.WriteLine("Schreibe bitte deine Frage");
            string newQuestion = Console.ReadLine();
            newQuiz.question = newQuestion;

            Console.WriteLine("Wie viele Antworten willst du anzeigen lassen?");
            int amountOfAnswers = Int32.Parse(Console.ReadLine());
            newQuiz.answers = new Answer[amountOfAnswers];

            for (int i = 0; i < amountOfAnswers; i++)
            {
                Console.WriteLine("Nenne Antwortmöglichkeiten");
                string userAnswer = Console.ReadLine();
                Console.WriteLine("Is das die richtige Antwort? Schreibe bitte ja oder nein");
                string userAnswerTruth = Console.ReadLine();
                bool finalTruth;
                if (userAnswerTruth == "ja")
                {
                    finalTruth = true;
                }
                else
                {
                    finalTruth = false;
                }
                newQuiz.answers[i] = new Answer { text = userAnswer, truth = finalTruth };
            }
            listWithAllQuestionsAndAnswers.Add(newQuiz);
        }
    }
}