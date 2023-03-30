using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelEnteryState", menuName = "ScriptableObjects/Game/LevelEnteryState")]
public class LevelEnteryStateSo : GameStateSo
{
    [SerializeField] private Scene _scene;

    private readonly IAsyncSceneLoading _sceneLoading = new UnitySceneLoading();
    public override void Enter() =>
        _sceneLoading.LoadAsync(_scene);

    public override void Exit() { }
}
