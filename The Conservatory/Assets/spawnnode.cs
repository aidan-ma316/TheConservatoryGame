using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnnode : MonoBehaviour
{
    public bool isOccupied = false;

    public bool isPath = false;



    private void Start()
    {
        if (gameObject.tag == "Path")
        {
            isPath = true;
        }
    }
}
