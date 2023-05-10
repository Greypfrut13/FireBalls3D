using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnitySceneLoading : IAsyncSceneLoading
{
    public async Task LoadAsync(Scene scene)
    {
        await SceneManager.LoadSceneAsync(scene.Name, scene.LoadMode);
    }

    public async Task UnloadAsync(Scene scene)
    {
        await SceneManager.UnloadSceneAsync(scene.Name);
    }
}
