using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    public GameObject cube;
    public float volite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = cube.transform.position;
        if (pos.x > 1f)
        {
            Destroy(cube);
            return;
        }

        cube.transform.position = new Vector3(pos.x + volite * Time.deltaTime, pos.y, pos.z);
    }
}
