using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private MovePreferencesSo _movePreferences;

    [Header("Player")]
    [SerializeField] private PlayerInputHandler _inputHandler;
    [SerializeField] private Transform _player;

    public void StartMovingOn(Path path, Vector3 initialPosition, CancellationTokenSource cancellationTokenSource)
    {
        _player.position = initialPosition;

        new PlayerPathFollowing(
            new PathFollowing(path, _player, _movePreferences), 
            path, _inputHandler)
            .StartMovingAsync(cancellationTokenSource.Token);
    }
}
