using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class PlayerButton : MonoBehaviour
{
    [SerializeField] private string _levelSceneName =  "Arctic1";

    private void Start() 
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadLevel);
    }

    private void LoadLevel()
    {
        SceneManager.LoadSceneAsync(_levelSceneName, LoadSceneMode.Additive);
    }
}
