using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathObstaclesBuilder : MonoBehaviour
{
    [SerializeField] private Transform _root;

    private IReadOnlyList<Obstacle> _obstaclePrefabs;

    public void Initialize(IReadOnlyList<Obstacle> obstaclePrefabs)
    {
        _obstaclePrefabs = obstaclePrefabs;
    }

    public void Build(ObstacleCollisionFeedback feedback)
    {
        ObstaclesGeneration generation = new ObstaclesGeneration(_obstaclePrefabs);
        IEnumerable<Obstacle> obstacles = generation.Create(_root, feedback);
    }
}
