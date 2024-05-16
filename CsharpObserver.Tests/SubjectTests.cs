using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpObserver.Tests
{
    [TestFixture]
    internal class SubjectTests
    {
        [Test]
        public void Attach_AddObserverToList()
        {
            var subject = new Subject();
            var observer = new ObserverA();

            subject.Attach(observer);

            CollectionAssert.Contains(subject.GetObservers(), observer);
        }

        [Test]
        public void Detach_RemoveObserverFromList()
        {
            var subject = new Subject();
            var observer = new ObserverA();
            subject.Attach(observer);

            subject.Detach(observer);

            CollectionAssert.DoesNotContain(subject.GetObservers(), observer);
        }

        [Test]
        public void Notify_CallUpdateOnAllObservers()
        {
            var subject = new Subject();
            var observerA = new ObserverA();
            var observerB = new ObserverB();
            subject.Attach(observerA);
            subject.Attach(observerB);
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);
            string expectedMessageA = "ObserverA has been updated.";
            string expectedMessageB = "ObserverB has been updated.";

            subject.Notify();
            string actualOutput = consoleOutput.ToString().Trim();

            Assert.IsTrue(actualOutput.Contains(expectedMessageA));
            Assert.IsTrue(actualOutput.Contains(expectedMessageB));
        }
    }

}
