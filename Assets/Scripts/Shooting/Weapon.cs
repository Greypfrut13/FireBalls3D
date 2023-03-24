using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class Weapon : MonoBehaviour
{
    private readonly Transform _shootPoint;
    private readonly Projectile _projectilePrefab;
    private readonly float _projectileSpeed;

    public Weapon(Transform shootPoint, Projectile projectile, float projectileSpeed)
    {
        _shootPoint = shootPoint;
        _projectilePrefab = projectile;
        _projectileSpeed = projectileSpeed;
    }

    public void Shoot()
    {   
        UnityObject
            .Instantiate(_projectilePrefab)
            .Shoot(_shootPoint.position, 
                _shootPoint.forward, 
                _projectileSpeed);
    }
}