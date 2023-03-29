using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public interface IAsyncTowerGenerator 
{
    Task<Tower> CreateAsync(Transform tower);
}
