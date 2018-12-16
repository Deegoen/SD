using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

using System.Globalization;
using Newtonsoft.Json.Converters;

namespace L7
{
    class QuizBinary : Quizelement
    {
        [JsonProperty("correct")]
        bool correct{get; set;}
        public QuizBinary(String question, bool isTrue)
        {
            this.question = question;
            this.correct = isTrue;
            this.callToAction = "Tippen Sie ja oder nein?(j/n):";
            this.type ="Binary";
        }
        public override void Show()
        {
            Console.WriteLine(question);
            
        }
        public override bool IsAnswerChoiceCorrect(string choice)
        {
            bool theAnswer = (choice == "j");
            if (theAnswer == correct)
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