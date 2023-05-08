using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private PathSegment[] _segments = Array.Empty<PathSegment>();

    public IReadOnlyList<PathSegment> Segments => _segments;

    public void Initialize(IReadOnlyList<PathPlatform> playformStructures, ObstacleCollisionFeedback feedback, CancellationTokenSource cancellationTokenSource)
    {
        for(int i = 0; i < playformStructures.Count; i++)
        {
            PathPlatformBuilder builder = _segments[i].PlatformBuilder;
            builder.Initialize(playformStructures[i], feedback, cancellationTokenSource);
        }
    }
}
