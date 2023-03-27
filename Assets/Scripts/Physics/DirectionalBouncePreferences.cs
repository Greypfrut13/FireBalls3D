using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DirectionalBouncePreferences 
{
    public float Duration;
    public float Height;
    public AnimationCurve Trajectory;

    public DirectionalBouncePreferences(float duration, float height, AnimationCurve trajectory)
    {
        Duration = duration;
        Height = height;
        Trajectory = trajectory;
    }
}
