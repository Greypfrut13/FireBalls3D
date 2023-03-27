using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DirectionalBouncePreferences", menuName = "ScriptableObjects/Physics/DirectionalBouncePreferences")]
public class DirectionalBouncePreferencesSo : ScriptableObject
{
    [SerializeField] private DirectionalBouncePreferences _value;

    public DirectionalBouncePreferences Value => _value;
}
