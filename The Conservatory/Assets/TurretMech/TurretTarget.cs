using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTarget : MonoBehaviour
{
   public Transform Base;
   
   GameObject theTarget;
   public Transform TargetLoc;

    public float range = 2f;

    private void Start()
    {
        Base = GameObject.FindGameObjectWithTag("Base").transform;
        InvokeRepeating("findTheTarget", 0f, .5f);
    }

    void findTheTarget()
    {
        TargetLoc = null;
        float closest = Mathf.Infinity;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            float distance = (Vector3.Distance(enemy.transform.position, Base.position));
            float d = (Vector3.Distance(enemy.transform.position, gameObject.transform.position));
            if (distance < closest && d <= range)
            {
                closest = distance;
                theTarget = enemy;
                TargetLoc = enemy.transform;
            }


        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Target the one closest to base and in range
                //get all the enemies
                    //find the one closest to the base
                        //check in in range
                            //if not then go to the next one

        }
    }
}
