using System;

namespace MoodAnalyser_UC
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Mood a= new Mood();
            Console.WriteLine("Enter mood");
            string c= Console.ReadLine();
          Console.WriteLine(  a.check(c));
            
        }
    }
}
