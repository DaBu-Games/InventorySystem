using UnityEngine;
using System.Collections.Generic;

public class InventorySubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update();
        }
        
        _observers.Clear();
    }
}
