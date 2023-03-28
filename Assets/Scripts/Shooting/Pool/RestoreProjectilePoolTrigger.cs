using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RestoreProjectilePoolTrigger : MonoBehaviour
{   
    [SerializeField] private ProjectilePool _pool;

    public event Action ProjectileReturned;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out Projectile projectile) == false)
            return;
        
        _pool.Return(projectile);
        ProjectileReturned?.Invoke();
    }   
}
