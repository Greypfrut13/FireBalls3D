using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3RangedRangedTweenData : RangedTweenData<Vector3> {}

public class Vector2RangedRangedTweenData : RangedTweenData<Vector2> {}

public class RangedTweenData <T> : TweenData<T>
{
    public T From;
}
