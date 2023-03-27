using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalBounce
{
    private readonly Transform _bouncer;
    private readonly CoroutineExecutor _coroutineExecutor;
    private readonly DirectionalBouncePreferences _preferences;

    public DirectionalBounce(Transform bouncer, CoroutineExecutor coroutineExecutor, DirectionalBouncePreferences preferences)
    {
        _bouncer = bouncer;
        _coroutineExecutor = coroutineExecutor;
        _preferences = preferences;
    }

    public void BounceTo(Vector3 target, Vector3 startPosition) => 
        _coroutineExecutor.Start(InterpolatePositionTo(target, startPosition));
    

    private IEnumerator InterpolatePositionTo(Vector3 target,  Vector3 startPosition)
    {
        var timer = new UnityTimer();
        timer.Start(_preferences.Duration);

        while(timer.IsTimeUp == false)
        {
            float t = timer.ElapsedTimePercent;

            Vector3 newPosition = CalculatePosition(target, startPosition, t);

            _bouncer.transform.position = newPosition;

            yield return null;
        }
    }

    private Vector3 CalculatePosition(Vector3 target, Vector3 startPosition, float t)
    {
        return Vector3.Lerp(startPosition, target, t)
        + Vector3.up * (_preferences.Trajectory.Evaluate(t) * _preferences.Height);
    }
}
