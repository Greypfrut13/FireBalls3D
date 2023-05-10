using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class PlayerButton : MonoBehaviour
{
    [SerializeField] private GameStateMachineSo _stateMachine; 

    private void Start() 
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(_stateMachine.Enter<LevelEnteryStateSo>);
    }
}
