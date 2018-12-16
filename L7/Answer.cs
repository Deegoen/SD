using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace L7
{
    public class Answer
    {   
        [JsonProperty("text")]
        public string text{get; set; }

        [JsonProperty("isTrue")]
        public bool isTrue{get; set;}

        public Answer(String text, Boolean isCorrect)
        {
            this.text = text;
            this.isTrue = isTrue;
        }

    }
}