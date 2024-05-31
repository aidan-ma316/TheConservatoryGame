using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireturret : MonoBehaviour
{
    public float splashDamage = 5f;

    public GameObject Bullet;
    protected Transform Target;
    public Turret turry;

    public float damage = 10;
    public float attackSpeed = 1f;
    bool check;
    private bool up = true;
    private int animcount = 0;


    //public Item item; FOR IMPLEMENTING ITEMS


    // Start is called before the first frame update
    private void Start()
    {
        Target = null;
        turry = GetComponent<Turret>();
        InvokeRepeating("Attack", .5f, 1 / attackSpeed);
        InvokeRepeating("animated", .5f, .1f);
    }

    void Attack()
    {
        Target = GetComponent<TurretTarget>().TargetLoc;
        if (Target != null)
        {
            if (Target.position.x < transform.position.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (Target.position.x > transform.position.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }



            GameObject b = (GameObject)Instantiate(Bullet, transform.position, transform.rotation);
            splashBullet bf = b.GetComponent<splashBullet>();
            b.transform.parent = transform;


            if (Bullet != null)
            {
                bf.getTarget(Target, damage);
                // Shoot Towards Target position
            }
        }


    }

    private void Update()
    {
        if (turry.xp >= turry.xpToLevel && turry.level < turry.maxlevel) { damage += 1; attackSpeed -= .3f; }

        if (gameObject.GetComponent<Turret>().evo > 1 && check == false) { damage+=3; gameObject.GetComponent<TurretTarget>().range += .5f; check = true; }
    }

    void animated()
    {
        if(up == true)
        {
            gameObject.transform.Translate(new Vector3(0, 0.04f, 0));
            animcount++;
            if (animcount >= 6)
            {
                up = false;
            }
        }
        else if (up == false)
        {
            gameObject.transform.Translate(new Vector3(0, -0.04f, 0));
            animcount--;
            if (animcount <= 0)
            {
                up = true;
            }
        }
    }
    
}
