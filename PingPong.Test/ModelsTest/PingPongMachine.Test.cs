using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong
{
[TestClass]
    public class PingPongTest
    {
        [TestMethod]
        public void Number_IsDivisibleByFiveAndThree_PingPong()
        {
            NumberProcessor testProcessor = new NumberProcessor();
            Assert.AreEqual ("PingPong", testProcessor.DoTheThing(60));
        }
        [TestMethod]
        public void Number_IsDivisibleByFiveButNotThree_Pong()
        {
            NumberProcessor testProcessor = new NumberProcessor();
            Assert.AreEqual ("Pong", testProcessor.DoTheThing(55));
        }
        [TestMethod]
        public void Number_IsDivisibleByThreeButNotFive_Ping()
        {
            NumberProcessor testProcessor = new NumberProcessor();
            Assert.AreEqual ("Ping", testProcessor.DoTheThing(21));
        }
        [TestMethod]
        public void Number_IsNotDivisibleByFiveOrThree_Number()
        {
            NumberProcessor testProcessor = new NumberProcessor();
            Assert.AreEqual("4", testProcessor.DoTheThing(4));
        }
    }
}