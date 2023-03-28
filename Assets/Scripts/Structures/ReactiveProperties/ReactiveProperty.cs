using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveProperty<T> : IReactiveProperty<T>
{
    private readonly List<Action<T>> _subscribers = new List<Action<T>>();

    public ReactiveProperty(T initialValue) =>
        Change(initialValue);

    public T Value { get; private set; }
    
    public void Subscribe(Action<T> valueChanged)
    {
        valueChanged?.Invoke(Value);
        _subscribers.Add(valueChanged);
    }

    public void Unsubscribe(Action<T> valueChanged)
    {
        _subscribers.Remove(valueChanged);
    }

    public void Change(T value)
    {
        Value = value;
        _subscribers.ForEach(subcriber => subcriber.Invoke(Value));
    }
}
