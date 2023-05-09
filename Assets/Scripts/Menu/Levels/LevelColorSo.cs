using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelColor", menuName = "ScriptableObjects/Menu/Level/Colors")]
public class LevelColorSo : ScriptableObject
{
    [SerializeField] private Color _passedLevels = Color.green;
    [SerializeField] private Color _nextLevels = Color.white;

    public Color PassedLevels => _passedLevels;

    public Color NextLevels => _nextLevels;
}
