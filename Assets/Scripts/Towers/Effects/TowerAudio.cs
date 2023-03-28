using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TowerAudio : MonoBehaviour
{
    [SerializeField] private  AudioClip _segmentRemoveSound;

    [Header("Pitch Preferences")]
    [SerializeField] private float _startPitch;
    [SerializeField] private float _maxPitch;
    [SerializeField] private float _pitchIncreaseStep;

    private AudioSource _audioSource;
    private float _currentPitcLevel;

    private void Start() 
    {
        _audioSource = GetComponent<AudioSource>();
        _currentPitcLevel = _startPitch;
    }

    public void PlaySound(int segmentCount)
    {
        _currentPitcLevel = Mathf.Clamp(_currentPitcLevel + _pitchIncreaseStep ,_startPitch, _maxPitch);

        _audioSource.pitch = _currentPitcLevel;
        _audioSource.PlayOneShot(_segmentRemoveSound);
    }
}
