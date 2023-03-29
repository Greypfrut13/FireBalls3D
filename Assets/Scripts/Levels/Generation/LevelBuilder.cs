using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [Header("Path")]
    [SerializeField] private Transform _pathRoot;
    [SerializeField] private LevelStructureSo _structure;

    [Header("Player")]
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private ObstacleCollisionFeedback _obstacleCollisionFeedback;

    private void Start() 
    {
        Build();
    }

    private void Build()
    {
        Path path = _structure.CreatePath(_pathRoot, _obstacleCollisionFeedback);
        Vector3 initialPosition = path.Segments[0].Waypoints[0].position;

        _playerMovement.StartMovingOn(path, initialPosition);
    }
}
