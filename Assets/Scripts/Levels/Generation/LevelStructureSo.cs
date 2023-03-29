using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelStructure", menuName = "ScriptableObjects/Levels/LevelStructure")]
public class LevelStructureSo : ScriptableObject
{
    [SerializeField] private Path _pathPrefab;
    [SerializeField] private List<PathPlatform> _platforms = new List<PathPlatform>();

    private void OnValidate() 
    {
        if(_pathPrefab is null)
            return;
        
        for(int i = _platforms.Count; i < _pathPrefab.Segments.Count; i++)
        {
            _platforms.Add(default);
        }
    }

    public Path CreatePath(Transform pathRoot, ObstacleCollisionFeedback feedback)
    {
        Path path = Instantiate(_pathPrefab, pathRoot);
        path.Initialize(_platforms, feedback);

        return path;
    }
}
