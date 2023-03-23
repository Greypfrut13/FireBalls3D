using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

[System.Serializable]
public class FloatRange : Range<float>
{
    public float Random => UnityRandom.Range(Min, Max);
}
