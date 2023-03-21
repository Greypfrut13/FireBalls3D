using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButtonDropDownAnimation : MonoBehaviour
{
    [SerializeField] private Vector2RangedRangedTweenData _buttonsTweenData;
    [SerializeField] private GameObject _actionRoot;
    [SerializeField] private float _delayBeywenButtons;

    private RectTransform[] _buttonTransforms;
    private bool _active = false;

    private void Start() 
    {
        _buttonTransforms = _actionRoot.GetComponentsInChildren<RectTransform>();
        TweenButtonSizes(_active, _buttonsTweenData);
    }

    public void OnButtonClicled()
    {
        _active = !_active;
        TweenButtonSizes(_active, _buttonsTweenData);
    }

    private void TweenButtonSizes(bool active, Vector2RangedRangedTweenData tweenData)
    {
        float delay = 0.0f;

        foreach(RectTransform buttonTransform in _buttonTransforms)
        {
            Vector2 sizeDelta = active ? tweenData.To : tweenData.From;

            buttonTransform
                .DOSizeDelta(sizeDelta, tweenData.Duration)
                .SetDelay(delay)
                .SetEase(tweenData.Ease);

            delay += _delayBeywenButtons;
        }
    }
}
