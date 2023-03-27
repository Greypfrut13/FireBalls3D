using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private PlayerInputHandler _playerInputHandler;
    [SerializeField] private ProjectilePool _pool;

    [SerializeField] private ProjectileFactory _projectileFactory;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.TryGetComponent(out Projectile projectile) == false)   
            return; 

        Vector3 hitPoint = other.contacts[0].point;
    }
}
