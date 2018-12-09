using System;
using System.Collections.Generic;

namespace L7
{

    class Program
    {
        static List<Quizelement> listOfQuestions = new List<Quizelement>();
        static int score = 0;
        static int answeredQuestions = 0;
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("Score: " + score + "\nBeantwortete Fragen: " + answeredQuestions + "\nWas wollen sie tun?\n 1) Spielen \n 2) Frage hinzufügen \n 3) Beenden");
                userInput = Int32.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        AskQuestion();
                        break;
                    case 2:
                        AddQuizelement();
                        break;
                    case 3:
                        if (score > 0)
                        {
                            Console.WriteLine("Du hast  " + score + " Punkt(e) erreicht. Glückwunsch!");
                        }
                        else
                        {
                            Console.WriteLine("Du hast leider nur  " + score + " Punkt(e) erreicht. Versuch es erneut!");
                        }
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bitte wählen Sie eine der Optionen(1/2/3) \n");
                        break;
                }
            } while (userInput != 3);
        }

        static public void AskQuestion()
        {
            listOfQuestions.Add(new QuizSingle("Wer ist amtierender Torschützenkönig der Bundesliga?", new Answer[] {
                new Answer("Mario Götze", false),
                new Answer("Robert Lewandowski", true),
                new Answer("Mario Gomez", false),
                new Answer("Bastian Schweinsteiger", false)
            }));
            listOfQuestions.Add(new QuizMultiple("Welche Aussage trifft auf die Budnesliga zu?", new Answer[] {
                new Answer("Es steigen sicher zwei Teams ab.", true),
                new Answer("Es gibt 18 Teams.", true),
                new Answer("Platz 1 und 2 teilen sich die Meisterschaft.", false),
                new Answer("Die Bundesliga besteht aus 20 Teams.", false)
            }));
            listOfQuestions.Add(new QuizBinary("Borussia Dortmund ist aktuell Tabellenführer", true));
            listOfQuestions.Add(new QuizGuess("Welches Jahr haben wir aktuell?", 2018));
            listOfQuestions.Add(new QuizFree("Wie heißt unsere Bundeskanzlrerin?", "Angela Merkel"));

            int randomQuizElement = random();
            listOfQuestions[randomQuizElement].show();
            string choice = Console.ReadLine();
            if (listOfQuestions[randomQuizElement].isAnswerCorrect(choice))
            {
                Console.WriteLine("Richtige Antwort! \n");
                score++;
                answeredQuestions++;
            }
            else
            {
                Console.WriteLine("Falsche Antwort! \n");
                score--;
            }
        }

        public static int random()
        {
            Random rnd = new Random();
            int rInt = rnd.Next(listOfQuestions.Count);
            return rInt;
        }

        static public void AddQuizelement()
        {
            Console.WriteLine("Was für einen Fragetyp wollen Sie hinzufügen? \n 1. QuizSingle \n 2. QuizMultiple \n 3. QuizBinary \n 4. QuizGuess \n 5. QuizFree");
            string questionType = Console.ReadLine();
            Console.WriteLine("Wie lautet die Frage?");
            string question = Console.ReadLine();
            switch (questionType)
            {
                case "1":
                    listOfQuestions.Add(NewQuizSingle(question));
                    break;
                case "2":
                    listOfQuestions.Add(NewQuizMultiple(question));
                    break;
                case "3":
                    listOfQuestions.Add(NewQuizBinary(question));
                    break;
                case "4":
                    listOfQuestions.Add(NewQuizFree(question));
                    break;
                case "5":
                    listOfQuestions.Add(NewQuizFree(question));
                    break;
            }
            Console.WriteLine("Ihre Frage wurde erfolgreich hinzugefügt");
        }

        public static Quizelement NewQuizSingle(string question)
        {
            Console.WriteLine("Wie viele mögliche Antworten soll Ihre Fragen haben?");
            int numberOfAnswers = Int32.Parse(Console.ReadLine());
            Answer[] arrayOfAnswers = new Answer[numberOfAnswers];
            Console.WriteLine("Die korrekte Antwort lautet:");
            arrayOfAnswers[0] = new Answer(Console.ReadLine(), true);
            for (int i = 1; i < numberOfAnswers; i++)
            {
                Console.WriteLine("Tippen Sie bitte falsche Antworten ein:");
                arrayOfAnswers[i] = new Answer(Console.ReadLine(), false);
            }
            return new QuizSingle(question, arrayOfAnswers);
        }

        public static Quizelement NewQuizMultiple(string question)
        {
            Console.WriteLine("Wie viele mögliche Antworten soll Ihre Fragen haben?");
            int numberOfAnswers = Int32.Parse(Console.ReadLine());
            Answer[] arrayOfAnswers = new Answer[numberOfAnswers];
            for (int i = 1; i < numberOfAnswers; i++)
            {
                Console.WriteLine("Tippen Sie eine Antwort ein:");
                string answer = Console.ReadLine();
                Console.WriteLine("Ist diese Antwort korrekt? (y/n)");
                bool isTrue = Console.ReadLine() == "y";
                arrayOfAnswers[i] = new Answer(answer, isTrue);
            }
            return new QuizSingle(question, arrayOfAnswers);
        }

        public static Quizelement NewQuizBinary(string question)
        {
            Console.WriteLine("Ist diese Antwort korrekt? (y/n)");
            bool theAnswer = Console.ReadLine() == "y";
            return new QuizBinary(question, theAnswer);
        }

        public static Quizelement NewQuizGuess(string question)
        {
            Console.WriteLine("Was ist die richtige Antwort?");
            return new QuizGuess(question, Int32.Parse(Console.ReadLine()));
        }

        public static Quizelement NewQuizFree(string question)
        {
            Console.WriteLine("Was ist die richtige Antwort?");
            return new QuizFree(question, Console.ReadLine());
        }
    }
}