using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character")]
    [SerializeField] private CharacterContrainerSo _characterContainter;

    [Header("Path")]
    [SerializeField] private MovePreferencesSo _movePreferences;
    [SerializeField] private Path _path;

    [Header("Shooting")]
    [SerializeField] private ShootingPreferencesSo _shootingPreferences;
    [SerializeField] private ProjectilePool _projectilePool;


    private FireRate _fireRate;
    private Weapon _weapon;
    private PathFollowing _pathFollowing;

    private void Start() 
    {
        Character character = _characterContainter.Create(transform);

        _projectilePool.Initialize(_shootingPreferences.ProjectileFactory);
        _projectilePool.Prewarm();

        _weapon = new Weapon(character.ShootPoint, _projectilePool, _shootingPreferences.ProjectileSpeed);
        _fireRate = new FireRate(_shootingPreferences.FireRate);
        _pathFollowing = new PathFollowing(_path, this, _movePreferences);
    }

    public void Shoot() =>
        _fireRate.Shoot(_weapon);

    [ContextMenu("Move")]
    public void Move()
    {
        _pathFollowing.MoveToNext();
    }
}
