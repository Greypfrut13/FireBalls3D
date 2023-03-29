using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public struct TowerDisassemblingAwaitor : INotifyCompletion
{
    private readonly TowerDisassembling _disassembling;
    private Action _continuation;

    public TowerDisassemblingAwaitor(TowerDisassembling disassembling)
    {
        _disassembling = disassembling;
        _continuation = null;
        IsCompleted = false;
    }

    public bool IsCompleted { get; private set; }

    public string GetResult() => string.Empty;

    public void OnCompleted(Action continuation)
    {
        _continuation = continuation; 
        _disassembling.Disassembled += OnTowerDisassembled;
    }

    private void OnTowerDisassembled()
    {
        _continuation.Invoke();
        IsCompleted = true;
    }
}
