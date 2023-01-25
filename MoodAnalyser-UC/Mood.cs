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
            //try
            //{
                if (this.message.Contains("i am sad"))
                {
                    return "sad";


                }

                if (this.message.Contains("i am Happy"))
                {
                    return "happy";
                }
                if(this.message.Contains("i am in any mood"))
                {
                    return "Happy";
                }
            //}
            //catch (Exception e)
            //{
            //    return "happy";
            //}
            return "don't know";


        }
      
    }
}
