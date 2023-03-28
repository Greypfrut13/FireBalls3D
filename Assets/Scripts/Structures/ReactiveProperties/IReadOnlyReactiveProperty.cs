using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public interface IReadOnlyReactiveProperty<out T>
{
    T Value { get; }

    void Subscribe(Action<T> valueChanged);
    void Unsubscribe(Action<T> valueChanged);
}
