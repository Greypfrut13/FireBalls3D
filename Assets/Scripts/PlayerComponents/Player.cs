using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private ShootingPreferencesSo _shootingPreferences;

    private FireRate _fireRate;
    private Weapon _weapon;

    private void Start() 
    {
        _weapon = _shootingPreferences.CreateWeapon(_character.ShootPoint);
        _fireRate = _shootingPreferences.CreateFireRate();
    }

    public void Shoot()
    {
        _fireRate.Shoot(_weapon);
    }
}
