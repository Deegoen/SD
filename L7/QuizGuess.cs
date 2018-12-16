using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

using System.Globalization;
using Newtonsoft.Json.Converters;


namespace L7
{
    class QuizGuess : Quizelement
    {
        [JsonProperty("correct")]
        public int correct { get; set; }
        public QuizGuess(String question, int correct)
        {
            this.question = question;
            this.correct = correct;
            this.callToAction = "Schätzen Sie die richtige Zahl:";
            this.type = "Guess";

        }
        public override void Show()
        {
            Console.WriteLine(question);
            Console.WriteLine(callToAction);
        }
        public override bool IsAnswerChoiceCorrect(string choice)
        {
            try
            {
                int currentChoice = Int32.Parse(choice);
                if (currentChoice == correct)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch
            {
                Console.WriteLine("Ihre Eingabe war ungültig.");
                return false;
            }
        }
    }
}