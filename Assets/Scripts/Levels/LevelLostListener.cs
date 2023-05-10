using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LevelLostListener : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private AssetReferenceGameObject _loseScreen;

    private void OnEnable() 
    {
        _player.Died +=  OnPlayerDied;
    }

    private void OnDisable() 
    {
        _player.Died -=  OnPlayerDied;
    }

    private void OnPlayerDied()
    {
        _loseScreen.InstantiateAsync();
    }
}
