using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityObject = UnityEngine.Object;

[CreateAssetMenu(fileName = "LevelEnteryState", menuName = "ScriptableObjects/Game/LevelEnteryState")]
public class LevelEnteryStateSo : GameStateSo
{
    [SerializeField] private Scene _playerGeneratedPathScene;
    [SerializeField] private UnityObject _levelProvider;
    [SerializeField] private PathStructureContainerSo _pathStructureContainter;

    private readonly IAsyncSceneLoading _sceneLoading = new AddressablesSceneLoading();

    private ILevelProvider LevelProvider => (ILevelProvider) _levelProvider;

    private Level Level => LevelProvider.Current;

    private void OnValidate() 
    {
        Inspector.ValidateOn<ILevelProvider>(ref _levelProvider);
    }

    public override async void Enter() 
    {
        _pathStructureContainter.PathStructure = Level.PathStructure;

        await _sceneLoading.LoadAsync(Level.LocationScene);
        await _sceneLoading.LoadAsync(_playerGeneratedPathScene);
    }

    public override void Exit() { }
}
