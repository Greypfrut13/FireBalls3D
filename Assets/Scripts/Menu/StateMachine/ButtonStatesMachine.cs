using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ButtonStatesMachine : MonoBehaviour
{
    [SerializeField] private MonoState[] _states = Array.Empty<MonoState>();

    private int _currentStateIndex;

    private void Start() 
    {
        Initialize();
    }

    public void ChangeOnNextState()
    {
        _currentStateIndex = GetNextStateIndex(_currentStateIndex);
        _states[_currentStateIndex].Enter();
    }

    private void Initialize()
    {
        if(_states.Length == 0)
        {
            enabled = false;
            throw new InvalidOperationException("States should be initialized");
        }

        _currentStateIndex = 0;
        _states[_currentStateIndex].Enter();
    }

    private int GetNextStateIndex(int currentIndex)
    {
        return (currentIndex + 1) % _states.Length;
    }
}
