using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExt
{
    // Generate random Vector3
    public static Vector3 Random3(this Vector3 vec3, Vector3 minVector, Vector3 maxVector)
    {
        vec3.x = Random.Range(minVector.x, maxVector.x);
        vec3.y = Random.Range(minVector.y, maxVector.y);
        vec3.z = Random.Range(minVector.z, maxVector.z);
        return vec3;
    }

    // Quick change desired axis
    public static Vector3 With(this Vector3 vec3, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? vec3.x, y ?? vec3.y, z ?? vec3.z);
    }

    // Flat, with default y = 0
    public static Vector3 Flat(this Vector3 vec3, float y = 0)
    {
        return new Vector3(vec3.x, y, vec3.z);
    }

    // Direction To
    public static Vector3 DirectionTo(this Vector3 souce, Vector3 destination)
    {
        return Vector3.Normalize(destination - souce);
    }
}
