using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelProvider
{
    Level Current { get; }
}
