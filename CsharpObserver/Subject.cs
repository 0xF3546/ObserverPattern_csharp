namespace CsharpObserver
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> observers = new();
        public void Attach(IObserver observer)
        {
            Console.WriteLine($"Added observer \"{observer.GetType().Name}\"");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine($"Removed observer \"{observer.GetType().Name}\"");
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public ICollection<IObserver> GetObservers()
        {
            return observers;
        }
    }
}
