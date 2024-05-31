using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    public  Transform[] t;
    void Awake()
    {
        t = new Transform[transform.childCount];

        for (int i =0; i < t.Length; i++)
        {
            t[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
