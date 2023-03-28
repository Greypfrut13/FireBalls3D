using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower 
{
    private readonly Queue<TowerSegment> _segments;

    public Tower(IEnumerable<TowerSegment> segments) : this(new Queue<TowerSegment>(segments)) {}

    public Tower(Queue<TowerSegment> segments)
    {
        _segments = segments;
    }

    public int SegmentCount => _segments.Count;

    public TowerSegment RemoveBottom() =>
        _segments.Dequeue();
}
