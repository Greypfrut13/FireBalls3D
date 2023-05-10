using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

public class PathPlatformBuilder : MonoBehaviour
{
    [SerializeField] private PathTowerBuilder _towerBuilder;
    [SerializeField] private PathObstaclesBuilder _obstaclesBuilder;

    private ObstacleCollisionFeedback _obstacleCollisionFeedback;
    private CancellationTokenSource _cancellationTokenSource;


    public void Initialize(PathPlatform pathPlatform, ObstacleCollisionFeedback collisionFeedback, CancellationTokenSource cancellationTokenSource)
    {
        _towerBuilder.Initialize(pathPlatform.TowerStructure);
        _obstaclesBuilder.Initialize(pathPlatform.Obstacles);

        _obstacleCollisionFeedback = collisionFeedback;
        _cancellationTokenSource = cancellationTokenSource;
    }

    public async Task<(TowerDisassembling, ObstacleDissapearing)> BuildAsync()
    {
        TowerDisassembling disassemnbling = await _towerBuilder.BuildAsync(_obstacleCollisionFeedback.PlayerProjectilePool, _cancellationTokenSource.Token);

        if(_cancellationTokenSource.IsCancellationRequested)
            return (disassemnbling, null);

        ObstacleDissapearing disappearing = _obstaclesBuilder.Build(_obstacleCollisionFeedback);

        return (disassemnbling , disappearing);
    }
}
