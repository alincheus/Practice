using System;

class Subject
{
    public delegate void Notify(string message);
    public event Notify EventOccurred;

    public void TriggerEvent(string message)
    {
        EventOccurred?.Invoke(message);
    }
}

class ObserverOne
{
    public void ReactionOne(string message)
    {
        Console.WriteLine($"ObserverOne реагирует: {message}");
    }

    public void ReactionTwo(string message)
    {
        Console.WriteLine($"ObserverOne реагирует вторично: {message}");
    }
}

class ObserverTwo
{
    public void ReactionThree(string message)
    {
        Console.WriteLine($"ObserverTwo реагирует: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject();

        ObserverOne observerOne = new ObserverOne();
        ObserverTwo observerTwo = new ObserverTwo();

        subject.EventOccurred += observerOne.ReactionOne;
        subject.EventOccurred += observerOne.ReactionTwo;
        subject.EventOccurred += observerTwo.ReactionThree;

        Console.WriteLine("Событие №1:");
        subject.TriggerEvent("Событие произошло!");

        subject.EventOccurred -= observerOne.ReactionTwo;

        Console.WriteLine("Событие №2:");
        subject.TriggerEvent("Событие произошло снова!");
    }
}
