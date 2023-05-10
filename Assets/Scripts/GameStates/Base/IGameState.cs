using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameState 
{
    void Enter();
    void Exit();

    public class Empty : IGameState
    {
        public void Enter() { }

        public void Exit() { }
    }
}
