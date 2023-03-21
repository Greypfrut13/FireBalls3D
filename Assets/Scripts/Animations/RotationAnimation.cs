using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update() 
    {
        Rotate(_speed);
    }

    private void Rotate(float speed)
    {
        float angle = speed * Time.deltaTime;
        transform.Rotate(Vector3.forward, angle);
    }
}
