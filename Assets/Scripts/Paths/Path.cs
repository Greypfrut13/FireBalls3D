using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private PathSegment[] _segments = Array.Empty<PathSegment>();

    public IReadOnlyList<PathSegment> Segments => _segments;
}
