using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoState : MonoBehaviour, IState
{
    public abstract void Enter();
}