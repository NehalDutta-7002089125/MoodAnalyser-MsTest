using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser_UC;

namespace MoodAnalyser_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "i am sad";
            Mood a= new Mood(message);
            string mood = a.check();
            Assert.AreEqual(mood, "sad");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string message = "i am Happy";
            Mood a = new Mood(message);
            string mood = a.check();
            Assert.AreEqual(mood, "happy");
        }
    }
}
