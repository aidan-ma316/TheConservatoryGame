using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangernotif : MonoBehaviour
{
    int count=0;
    bool up = true;

   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delete());
        InvokeRepeating("animated", .25f, .08f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void animated()
    {
        if (up == true)
        {
            if (count <= 5)
            {
                transform.Translate(0, .01f, 0);
                count++;
            } else count = 0; up = false;  
        }


        if (up != true)
        {
            if (count <= 5)
            {
                transform.Translate(0, -.01f, 0);
                count++;
            }
            else count = 0; up = true;
        }
    }

    IEnumerator delete()
    {
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }


}
