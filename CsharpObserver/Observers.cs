namespace CsharpObserver
{
    public class ObserverA : IObserver
    {
        public void Update()
        {
            Console.WriteLine("ObserverA has been updated.");
        }
    }

    public class ObserverB : IObserver
    {
        public void Update()
        {
            Console.WriteLine("ObserverB has been updated.");
        }
    }
}
