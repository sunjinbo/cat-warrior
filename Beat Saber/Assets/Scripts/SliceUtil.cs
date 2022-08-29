using System.Collections;
using System.Collections.Generic;
using EzySlice;
using UnityEngine;

public class SliceUtil : MonoBehaviour
{
    public static GameObject[] slice(GameObject source, Vector3 slicePosition, Vector3 sliceDirect, Material mat)
    {
        var result = new GameObject[2];

        SlicedHull hull = source.Slice(slicePosition, sliceDirect);
        result[0] = hull.CreateUpperHull(source, mat);
        result[1] = hull.CreateLowerHull(source, mat);

        return result;
    }
}
