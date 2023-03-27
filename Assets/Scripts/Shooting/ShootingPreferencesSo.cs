using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShootingPreferencesSo", menuName = "ScriptableObjects/Shooting/Preferences")]
public class ShootingPreferencesSo : ScriptableObject
{
    [Header("Projectile")]
    [SerializeField] private ProjectileFactory _projectileFactory;
    [SerializeField] [Min(0.0f)] private float _projectileSpeed;

    [SerializeField] [Min(0.0f)] private float _fireRate;

    public ProjectileFactory ProjectileFactory => _projectileFactory;

    public float ProjectileSpeed => _projectileSpeed;

    public float FireRate => _fireRate;
}
