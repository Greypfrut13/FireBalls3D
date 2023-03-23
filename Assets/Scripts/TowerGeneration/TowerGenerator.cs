using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using DG.Tweening;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class TowerGenerator : MonoBehaviour
{
    [SerializeField] private UnityObject _towerFactory;
    [SerializeField] private Transform _tower;
    [SerializeField] private Vector3TweenData _rotationData;

    private IAsyncTowerFactory TowerFactory =>(IAsyncTowerFactory) _towerFactory;

    private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

    private void OnValidate() 
    {
        if(_towerFactory != null && _towerFactory is IAsyncTowerFactory == false)
        {
            _towerFactory = null;
            throw new InvalidOperationException("Tower factory should be derived from IAsyncTowerFactory");
        }    
    }

    private void OnDisable()
    {
        _cancellationTokenSource.Cancel();
    }

    [ContextMenu("Generate")]
    public async void Generate()
    {
        ApplyRotation(_rotationData);
        await TowerFactory.CreateAsync(_tower, _cancellationTokenSource.Token);
    } 

    private void ApplyRotation(Vector3TweenData rotationData)
    {
        _tower
            .DORotate(rotationData.To, rotationData.Duration, RotateMode.FastBeyond360)
            .SetEase(rotationData.Ease);
    }
}
