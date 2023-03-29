using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PathSegment
{
    public Transform[] Waypoints;
    public PathPlatformBuilder PlatformBuilder;
}
