using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public interface IAsyncTowerFactory 
{
    Task<Tower> CreateAsync(Transform tower, CancellationToken cancellationToken);
}
