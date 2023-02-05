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

        public  string check()
        {
            if (message.Contains(null))
            {
                return "null";
            }
                if (message.Contains("i am sad"))
                {
                    return "sad";


                }
                if (message.Contains("i am any mood"))
                {
                    return "happy";
                }
                else
                {
                    return "happy";
                }
            
            

        }


    }
}
