using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public Transform[] location;
    public GameObject cubePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateCube());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateCube()
    {
        for (int i = 0; i < 500; i++)
        {
            var index = Random.Range(0, location.Length);
            var transform = location[index];
            var cube = GameObject.Instantiate(cubePrefabs, transform);
            yield return new WaitForSeconds(1);
        }
    }
}
