using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExecutor 
{
    private readonly MonoBehaviour _executor;

    public CoroutineExecutor(MonoBehaviour executor)
    {
        _executor = executor;
    }

    public Coroutine Start(IEnumerator coroutine) => 
        _executor.StartCoroutine(coroutine);

    public void Stop(Coroutine coroutine) => _executor.StopCoroutine(coroutine);
}
