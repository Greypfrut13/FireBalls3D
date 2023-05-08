using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [Header("Path")]
    [SerializeField] private Transform _pathRoot;
    [SerializeField] private PathStructureSo _structure;

    [Header("Player")]
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private ObstacleCollisionFeedback _obstacleCollisionFeedback;

    private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

    private void Start() 
    {
        Build();
    }

    private void OnDisable() 
    {
        _cancellationTokenSource.Cancel();
    }

    private void Build()
    {
        Path path = _structure.CreatePath(_pathRoot, _obstacleCollisionFeedback, _cancellationTokenSource);
        Vector3 initialPosition = path.Segments[0].Waypoints[0].position;

        _playerMovement.StartMovingOn(path, initialPosition, _cancellationTokenSource);
    }
}
