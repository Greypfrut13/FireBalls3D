using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private ObstacleCollision _collision;

    public void Initialize(ObstacleCollisionFeedback feedback)
    {
        _collision.Initialize(feedback);
    }
}
