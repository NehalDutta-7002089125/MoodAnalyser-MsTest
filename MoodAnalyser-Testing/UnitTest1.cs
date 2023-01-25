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
            Mood a= new Mood();
            string mood = a.check(message);
            Assert.AreEqual(mood, "sad");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string message = "i am happy";
            Mood a = new Mood();
            string mood = a.check(message);
            Assert.AreEqual(mood, "happy");
        }
    }
}
