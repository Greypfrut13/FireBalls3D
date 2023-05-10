using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentLevel", menuName = "ScriptableObjects/Levels/CurrentLevel")]
public class CurrentLevel : ScriptableObject, ILevelNumberProvider, ILevelProvider, ILevelChanging
{
    [SerializeField] private LevelStorageSo _storage;
    [SerializeField] private LevelNumberSo _levelNumber;

    public int Value => _levelNumber.Value;

    public Level Current => _storage.Levels[_levelNumber.Value - 1];

    public void StepToNextLevel()
    {
        _levelNumber.Value = Mathf.Clamp(_levelNumber.Value + 1, 1, _storage.Levels.Count);
    }
}
