namespace CsharpObserver.Tests
{
    [TestFixture]
    internal class ObserverTests
    {
        [Test]
        public void ObserverA_Update_Should_WriteMessageToConsole()
        {
            var observerA = new ObserverA();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            string expectedMessage = "ObserverA has been updated.";

            observerA.Update();
            string actualMessage = consoleOutput.ToString().Trim();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ObserverB_Update_Should_WriteMessageToConsole()
        {
            var observerB = new ObserverB();
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);
            string expectedMessage = "ObserverB has been updated.";

            observerB.Update();
            string actualMessage = consoleOutput.ToString().Trim();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
