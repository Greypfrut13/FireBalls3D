using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character")]
    [SerializeField] private CharacterContrainerSo _characterContainter;


    [Header("Shooting")]
    [SerializeField] private ShootingPreferencesSo _shootingPreferences;
    [SerializeField] private ProjectilePool _projectilePool;


    private FireRate _fireRate;
    private Weapon _weapon;

    public event Action Died;

    private void Start() 
    {
        Character character = _characterContainter.Create(transform);

        _projectilePool.Initialize(_shootingPreferences.ProjectileFactory);
        _projectilePool.Prewarm();

        _weapon = new Weapon(character.ShootPoint, _projectilePool, _shootingPreferences.ProjectileSpeed);
        _fireRate = new FireRate(_shootingPreferences.FireRate);
    }

    public void Shoot() =>
        _fireRate.Shoot(_weapon);

    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out Projectile _))
        {
            Died?.Invoke();
        }
    }
}
