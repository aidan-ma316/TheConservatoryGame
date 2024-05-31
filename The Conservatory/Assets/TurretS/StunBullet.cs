using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunBullet : MonoBehaviour
{
    protected Transform target;
    public float speed = .5f;
    protected Vector3 dir;
    public float CCTimer;

    public bool isStun = true;

    public float damage = 5f;

    public void getTarget(Transform t, float d, float cc)
    {
        target = t;
        damage = d;
        CCTimer = cc;
    }

    public void Start()
    {
        dir = target.position - transform.position;
    }


    // Update is called once per frame
    void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);




    }

    protected IEnumerator Wait(float f)
    {

        yield return new WaitForSeconds(f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isStun == true)
        {
            float rand = Random.Range(0, 100);
            
            collision.gameObject.GetComponent<enemyUnit>().takeDamage(damage, gameObject);//take damage
            if (rand <= 35) {
                collision.gameObject.GetComponent<UnitMove>().slowORStun(0f, CCTimer);//stun
            }
        } else if (isStun == false)
        {
            collision.gameObject.GetComponent<enemyUnit>().takeDamage(damage, gameObject);//take damage
            collision.gameObject.GetComponent<UnitMove>().slowORStun(.50f, CCTimer);//stun
        }
        Destroy(gameObject);
    }
}
