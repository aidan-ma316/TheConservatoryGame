using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storedMonster : MonoBehaviour
{
    int animcount;
    bool up;
    SpriteRenderer sr;

    public GameObject turry;

    // Start is called before the first frame update
    void Start()
    {
        up = true;
        animcount = 0;
        sr = GetComponent<SpriteRenderer>();

        InvokeRepeating("animated", 0f, .1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MonsterMovement()
    {
        /*int rand;

        rand = Random.Range(0, 100);

        if (rand >= 0 && rand <= 10)
        {
            transform.Translate(0, .001f, 0);
        }
        if (rand >= 10 && rand <= 20)
        {
            transform.Translate(0, -.001f, 0);
        }
        if (rand >= 20 && rand <= 30)
        {
            transform.Translate(0.001f, 0, 0);
        }
        if (rand >= 30 && rand <= 40)
        {
            transform.Translate(-0.001f, 0, 0);
        } */


        
    }

    void animated()
    {
        if (up == true)
        {
            sr.flipX = true;
            gameObject.transform.Translate(new Vector3(0.1f, 0,  0));
            animcount++;
            if (animcount >= 10)
            {
                up = false;
            }
        }
        else if (up == false)
        {
            sr.flipX = false;
            gameObject.transform.Translate(new Vector3(-0.1f, 0, 0));
            animcount--;
            if (animcount <= 0)
            {
                up = true;
            }
        }
    }
}
