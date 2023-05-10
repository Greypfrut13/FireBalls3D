using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPathCompletion : IPassComplition
{
    private readonly IGameStateMachine _stateMachine;

    public LevelPathCompletion(IGameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Complete()
    {
        _stateMachine.Enter<LevelCompletedState>();
    }
}
