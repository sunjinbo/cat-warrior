using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public Material SliceMaterial;

    private void OnTriggerEnter(Collider other)
    {
        var hitPos = other.bounds.ClosestPoint(transform.position);
        var result = SliceUtil.slice(other.gameObject, hitPos, transform.right, SliceMaterial);

        Destroy(other.gameObject);

        for (int i = 0; i < result.Length; ++i)
        {
            result[i].AddComponent<SubCube>();
            result[i].AddComponent<Rigidbody>();
        }

        result[0].GetComponent<Rigidbody>().drag = 10; // 空气阻力
    }
}
