using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement 
{
    float Speed { get; }
    
    void Move(float speed);
}
