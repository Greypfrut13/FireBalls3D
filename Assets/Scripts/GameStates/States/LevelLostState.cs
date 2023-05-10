using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelLostState", menuName = "ScriptableObjects/Game/States/LevelLostState" )]
public class LevelLostState : GameStateSo
{
    [SerializeField] private Scene _menu;

    private readonly IAsyncSceneLoading _sceneLoading = new AddressablesSceneLoading();

    public override void Enter()
    {
        _sceneLoading.LoadAsync(_menu);
    }

    public override void Exit()
    {
    }
}
