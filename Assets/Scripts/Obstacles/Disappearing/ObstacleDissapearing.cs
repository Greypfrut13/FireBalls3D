using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class ObstacleDissapearing 
{
    private readonly Transform _obstaclesRoot;
    private readonly IEnumerable<Obstacle> _obstacles;
    private readonly IAwaitableTweenAnimation _animation;

    public ObstacleDissapearing(Transform obtaclesRoot, IEnumerable<Obstacle> obstacles, IAwaitableTweenAnimation animation)
    {
        _obstaclesRoot = obtaclesRoot;
        _obstacles = obstacles;
        _animation = animation;
    }

    public async Task ApplyAsync()
    {
        await _animation.ApplyTo(_obstaclesRoot);

        foreach(Obstacle obstacle in _obstacles)
            UnityObject.Destroy(obstacle.gameObject);

        await Task.CompletedTask;
    }
}
