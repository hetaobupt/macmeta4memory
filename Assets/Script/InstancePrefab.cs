using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InstancePrefab : MonoBehaviour
{
    public GameObject PolyArtBear;
    private int instanceCount = 0;
    private float timeDelay = 0.5f;
    private int xCount = 0;
    private int yCount = 0;
    private static int maxLineCount = 6;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeDelay -= Time.deltaTime;

        if ( instanceCount < maxLineCount*maxLineCount && timeDelay < 0)
        {

            Instantiate(PolyArtBear, new Vector3(xCount*5, 0, yCount*5), Quaternion.identity, gameObject.transform);
            instanceCount += 1;
            timeDelay = 0.5f;
            yCount += 1;
            if(yCount >= maxLineCount)
            {
                yCount = 0;
                xCount += 1;
            }
        }

    }
}
