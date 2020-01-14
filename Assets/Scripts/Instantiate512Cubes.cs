using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour
{
    public GameObject sampleCubePrefab;
    GameObject[] sampleCube = new GameObject[512];

    private bool jusBoolin = false;

    public float maxScale;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!jusBoolin)
        {
            SpawnObjects();
            jusBoolin = !jusBoolin;
        }
        
        
        for (int i = 0; i < 512; i++)
        {
            if (sampleCube != null)
            {
                sampleCube[i].transform.localScale = new Vector3(10,AudioPeer.samples[i] * maxScale, 10);
            }
        }
    }

    void SpawnObjects()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject instanceSampleCube = Instantiate(sampleCubePrefab, transform.position, new Quaternion(0f, (360/512)*i, 0f, 0f));
            
            instanceSampleCube.name = "SampleCube" + i;

            //spawns it 100 units away in facing direction
            instanceSampleCube.transform.position = instanceSampleCube.transform.forward * 100;

            sampleCube[i] = instanceSampleCube;
        }
    }
}
