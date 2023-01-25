using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MoodAnalyser_UC
{
    public class Mood
    {
        public string message;
        
        public Mood(string message)
        {
            this.message = message;
            
        }

        public string check()
        {
            if (this.message.Contains("sad"))
            {
                return "sad";


            }
            
            if (this.message.Contains(" Happy"))
            {
               return "happy";
            }
            return "i don't know";
        }
      
    }
}
