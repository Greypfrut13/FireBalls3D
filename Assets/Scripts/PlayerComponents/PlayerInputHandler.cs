using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] private InputTouchPanel _touchPanel;

    [Header("Player Components")]
    [SerializeField] private Player _player;

    private void OnEnable() 
    {
        _touchPanel.Holding += Shoot;
    }

    private void OnDisable() 
    {
        _touchPanel.Holding -= Shoot;
    }

    public void Enable()
    {
        enabled = true;
    }

    public void Disable()
    {
        enabled = false;
    }

    private void Shoot(Touch touch)
    {
        _player.Shoot();
    }
}
