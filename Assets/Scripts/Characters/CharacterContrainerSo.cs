using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterContrainer", menuName = "ScriptableObjects/Character/CharacterContrainer")]
public class CharacterContrainerSo : ScriptableObject
{
    public Character CharacterPrefab;

    public Character Create(Transform parent)
    {
        return Instantiate(CharacterPrefab, parent);
    }
}
