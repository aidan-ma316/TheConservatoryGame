using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTurret : MonoBehaviour
{
    public float stunTimer = .5f;

    public GameObject Bullet;
    protected Transform Target;

    bool up;
    int animcount;
 

    public Turret turry;
    public Sprite evo1;
    public Sprite evo2;
    bool check = false;

    public float damage = 10;
    public float attackSpeed = .5f;

    public int xp = 0;

    public string[] type = { "Baby", "Evo1", "Evo2", "Evo3" };

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = evo1;
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
            StunBullet sb = b.GetComponent<StunBullet>();
            sb.transform.parent = transform;


            if (Bullet != null)
            {
                sb.getTarget(Target, damage, stunTimer);
                // Shoot Towards Target position
            }
        }
    }

    void animated()
    {
        if (up == true)
        {
            gameObject.transform.Translate(new Vector3(0, 0.04f, 0));
            animcount++;
            if (animcount >= 4 )
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

    private void Update()
    {
        
        if (turry.xp >= turry.xpToLevel && turry.level < turry.maxlevel) { damage += 1; attackSpeed -= .3f; }

        if (gameObject.GetComponent<Turret>().evo > 1 && check == false) { damage += 3; gameObject.GetComponent<TurretTarget>().range += .5f; check = true; }

        //if (turry.evo == 2 && check == false) { damage *= 2; stunTimer *= 2; GetComponent<SpriteRenderer>().sprite = evo2; check = true; }
    }



    /**private void levelOccupy()
    {
        var ak = transform.position;
        Transform [] nodes = new Transform [3];
        int count = 1; 

        GameObject[] spawnplates = GameObject.FindGameObjectsWithTag("Node");
        Transform nearest = null;
        float shortest = Mathf.Infinity;

        for (count = 1; count <= 4; count++)
        {
            if (count == 1)
            {
                foreach (GameObject spawnplate in spawnplates)
                {
                    float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), spawnplate.transform.position);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        nearest = spawnplate.transform;
                    }
                }

                nearest = nodes[0];
                nearest.gameObject.GetComponent<spawnnode>().isOccupied = true;
            }


            if (count == 2)
            {
                foreach (GameObject spawnplate in spawnplates)
                {
                    float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), spawnplate.transform.position);
                    if (distance < shortest && spawnplate.gameObject.GetComponent<spawnnode>().isOccupied == false)
                    {
                        if (Vector3.Distance(new Vector3(ak.x, ak.y, 0),spawnplate.transform.position) < 1.4f && Vector3.Distance(nodes[0].transform.position, spawnplate.transform.position) < 1.4f) {
                            shortest = distance;
                            nearest = spawnplate.transform;
                        }
                    }
                }

                nearest = nodes[1];
                nearest.gameObject.GetComponent<spawnnode>().isOccupied = true;
            }

            if (count == 3)
            {
                foreach (GameObject spawnplate in spawnplates)
                {
                    float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), spawnplate.transform.position);
                    if (distance < shortest && spawnplate.gameObject.GetComponent<spawnnode>().isOccupied == false)
                    {
                        if (Vector3.Distance(new Vector3(ak.x, ak.y, 0), spawnplate.transform.position) < 1.4f && Vector3.Distance(nodes[0].transform.position, spawnplate.transform.position) < 1.4f)
                        {
                            shortest = distance;
                            nearest = spawnplate.transform;
                        }
                    }
                }

                nearest = nodes[1];
                nearest.gameObject.GetComponent<spawnnode>().isOccupied = true;
            }


            count++;
        }
    }
    **/

}
