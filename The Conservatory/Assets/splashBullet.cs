using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashBullet: bulletfollow
{
    public LayerMask layerEnemy;

    public float splashRadius = .2f;
    public bool boom = true;

    public GameObject child;




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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<enemyUnit>().takeDamage(damage, gameObject);

        boom = true;

        Collider2D[] Enemies = Physics2D.OverlapCircleAll(gameObject.transform.position, splashRadius, layerEnemy);

            foreach (Collider2D e in Enemies)
            {
            if (e.gameObject != collision.gameObject)
            {
                e.GetComponent<enemyUnit>().takeDamage(damage / 3, gameObject);
            }
            }
        GameObject c = Instantiate(child, transform.position, transform.rotation);
        c.transform.parent = transform.parent;


        Destroy(gameObject);
    }

    IEnumerator waitDestroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, splashRadius);
    }

}
