using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityObject = UnityEngine.Object;

public class TowerDisassembling 
{
    private readonly Tower _tower;
    private readonly Transform _towerRoot;

    public TowerDisassembling(Tower tower, Transform towerRoot)
    {
        _tower = tower;
        _towerRoot = towerRoot;
    }

    public void RemoveBottom()
    {
        TowerSegment segment = _tower.RemoveBottom();
        Vector3 segmentScale = segment.transform.localScale;

        _towerRoot.position -= Vector3.up * segmentScale.y;

        UnityObject.Destroy(segment.gameObject);
    }
}
