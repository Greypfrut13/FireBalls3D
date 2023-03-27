using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileFactory", menuName = "ScriptableObjects/Shooting/ProjectileFactory")]
public class ProjectileFactory : ScriptableObject, IFactory<Projectile>
{
    [SerializeField] private Projectile _projectilePrefab;

    public Projectile Create()
    {
        return Instantiate(_projectilePrefab);
    }
}
