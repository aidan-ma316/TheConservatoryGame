using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public GameObject Bullet;
    protected Transform Target;
    float Range;

    public float damage = 10;
    public float attackSpeed = 1f;


    // Start is called before the first frame update
    private void Start()
    {
        Target = GetComponent<TurretTarget>().TargetLoc;
        InvokeRepeating("Attack", .5f, 1/attackSpeed);
    }

    // Update is called once per frame
    void Update()
    {
    }


    void Attack () {
        Target = GetComponent<TurretTarget>().TargetLoc;
        Range = GetComponent<TurretTarget>().range;

        if (Target != null) {
            float distance = Vector3.Distance(Target.position, gameObject.transform.position);
            if (distance <= Range) {

                GameObject b = (GameObject)Instantiate(Bullet, transform.position, transform.rotation);
                bulletfollow bf = b.GetComponent<bulletfollow>();


                if (Bullet != null)
                {
                    bf.getTarget(Target, damage);
                    // Shoot Towards Target position
                }
            }
        }
    }

}
