using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

using System.Globalization;
using Newtonsoft.Json.Converters;

namespace L7
{
    public class Quizelement
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("question")]
        public string question { get; set; }

        public string callToAction;


        public virtual void Show()
        {

        }
        public virtual bool IsAnswerChoiceCorrect(string choice)
        {
            return true;
        }
    }
}