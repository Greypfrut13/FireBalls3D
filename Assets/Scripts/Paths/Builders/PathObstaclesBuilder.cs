using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathObstaclesBuilder : MonoBehaviour
{
    [SerializeField] private Transform _root;
    [SerializeField] private LocalMoveTweenSo _disappearAnimation;

    private IReadOnlyList<Obstacle> _obstaclePrefabs;

    public void Initialize(IReadOnlyList<Obstacle> obstaclePrefabs)
    {
        _obstaclePrefabs = obstaclePrefabs;
    }

    public ObstacleDissapearing Build(ObstacleCollisionFeedback feedback)
    {
        ObstaclesGeneration generation = new ObstaclesGeneration(_obstaclePrefabs);
        IEnumerable<Obstacle> obstacles = generation.Create(_root, feedback);

        return new ObstacleDissapearing(_root, obstacles, _disappearAnimation);
    }
}
