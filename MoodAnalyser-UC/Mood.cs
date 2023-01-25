using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MoodAnalyser_UC
{
    public class Mood
    {
        public string check(string message)
        {
            if (message.Contains("i am sad"))
            {
                return "sad";

                
            }
            if (message.Contains("i am happy"))
            {
                return "happy";
            }
            return "i don't know";
        }
    }
}
