using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public interface ITowerCreationSegmentCallback 
{
    event Action<int> SegmentCreated;
}
