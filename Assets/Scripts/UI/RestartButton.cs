using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RestartButton : MonoBehaviour
{
    [SerializeField] private GameStateMachineSo _stateMachine;

    private void Start() 
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(_stateMachine.Enter<LevelLostState>);
    }
}
