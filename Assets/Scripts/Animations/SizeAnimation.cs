using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeAnimation : MonoBehaviour
{
    [SerializeField] private Vector3TweenData _tweenData;

    private void Start() 
    {
        ApplyAnimation(_tweenData);
    }

    private void ApplyAnimation(Vector3TweenData tweenData)
    {
        transform
            .DOScale(tweenData.EndValue, tweenData.Duration)
            .SetEase(tweenData.Ease)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
