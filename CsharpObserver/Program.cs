using CsharpObserver;

Subject subject = new();
subject.Attach(new ObserverA());
subject.Notify();

subject.Attach(new ObserverB());
subject.Notify();

subject.Detach(new ObserverB());
subject.Notify();