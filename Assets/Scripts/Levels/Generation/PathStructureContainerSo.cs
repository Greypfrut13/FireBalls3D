using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PathStructureContainer", menuName = "ScriptableObjects/Levels/PathStructureContainer")]
public class PathStructureContainerSo : ScriptableObject
{
    public PathStructureSo PathStructure { get; set; }
}
