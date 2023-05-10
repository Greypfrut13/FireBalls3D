using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameStateSo : ScriptableObject, IGameState
{
    public abstract void Enter();

    public abstract void Exit();
}
