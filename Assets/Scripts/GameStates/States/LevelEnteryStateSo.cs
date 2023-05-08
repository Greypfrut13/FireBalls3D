using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelEnteryState", menuName = "ScriptableObjects/Game/LevelEnteryState")]
public class LevelEnteryStateSo : GameStateSo
{
    [SerializeField] private Scene _locationScene;
    [SerializeField] private Scene _playerGeneratedPathScene;

    private readonly IAsyncSceneLoading _sceneLoading = new AddressablesSceneLoading();
    public override void Enter() 
    {
        _sceneLoading.LoadAsync(_locationScene);
        _sceneLoading.LoadAsync(_playerGeneratedPathScene);
    }

    public override void Exit() { }
}
