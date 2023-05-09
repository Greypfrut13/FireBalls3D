using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelStorage", menuName = "ScriptableObjects/Levels/LevelStorage")]
public class LevelStorageSo : MonoBehaviour
{
    [SerializeField] private Level[] _levels = Array.Empty<Level>();

    public IReadOnlyList<Level> Levels => _levels;
}
