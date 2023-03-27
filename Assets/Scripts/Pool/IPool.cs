using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPool<T>
{
    void Prewarm();
    T Request();
    void Return(T member);
}
