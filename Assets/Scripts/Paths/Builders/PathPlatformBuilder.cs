using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PathPlatformBuilder : MonoBehaviour
{
    [SerializeField] private PathTowerBuilder _towerBuilder;
    [SerializeField] private PathObstaclesBuilder _obstaclesBuilder;

    private ObstacleCollisionFeedback _obstacleCollisionFeedback;

    public void Initialize(PathPlatform pathPlatform, ObstacleCollisionFeedback collisionFeedback)
    {
        _towerBuilder.Initialize(pathPlatform.TowerStructure);
        _obstaclesBuilder.Initialize(pathPlatform.Obstacles);

        _obstacleCollisionFeedback = collisionFeedback;
    }

    public async Task<(TowerDisassembling, ObstacleDissapearing)> BuildAsync()
    {
        TowerDisassembling disassemnbling = await _towerBuilder.BuildAsync(_obstacleCollisionFeedback.PlayerProjectilePool);
        ObstacleDissapearing disappearing = _obstaclesBuilder.Build(_obstacleCollisionFeedback);

        return (disassemnbling , disappearing);
    }
}
