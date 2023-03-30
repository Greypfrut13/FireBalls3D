using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public interface IAsyncSceneLoading 
{
    Task<AsyncOperation> LoadAsync(Scene scene);
    Task<AsyncOperation> UnloadAsync(Scene scene);
}
