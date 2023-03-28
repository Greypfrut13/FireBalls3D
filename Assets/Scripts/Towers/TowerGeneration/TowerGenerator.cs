using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class TowerGenerator : MonoBehaviour
{
    [SerializeField] private TowerFactory _towerFactory;
    [SerializeField] private Transform _towerRoot;
    [SerializeField] private Vector3TweenData _rotationData;

    private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

    public ITowerCreationSegmentCallback CreationCallback => _towerFactory;

    private void OnDisable()
    {
        _cancellationTokenSource.Cancel();
    }

    [ContextMenu("Generate")]
    public async Task<Tower> Generate()
    {
        ApplyRotation(_rotationData);
        return await _towerFactory.CreateAsync(_towerRoot, _cancellationTokenSource.Token);
    } 

    private void ApplyRotation(Vector3TweenData rotationData)
    {
        _towerRoot
            .DORotate(rotationData.To, rotationData.Duration, RotateMode.FastBeyond360)
            .SetEase(rotationData.Ease);
    }
}
