using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public static class Inspector 
{
    public static void ValidateOn<T>(ref UnityObject validatedObject)
    {
        if(validatedObject != null && validatedObject is T == false)
        {
            validatedObject = null;
            throw new InvalidOperationException($"{nameof(validatedObject)} should be derived from {typeof(T)}");
        }
    }
}
