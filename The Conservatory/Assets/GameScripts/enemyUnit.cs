using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyUnit : MonoBehaviour
{
    public float maxHealth = 50f;
    public float currHealth;

    public int xp2Give = 10;

    public bool isPoisoned;

    public GameObject damagePopUp;

    public Canvas canv;

    public GameObject mostrecentbullet;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currHealth <= 0)
        {
            Die();
        }
    }

   /** private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
   
            mostrecentbullet = collision.gameObject.transform.parent.gameObject;
        }
    }**/

    public void takeDamage(float d, GameObject r)
    {
       
        GameObject dp = Instantiate(damagePopUp, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + (d/15), 0), Quaternion.identity);

        dp.transform.parent = gameObject.transform;
        PrintDamage pd = dp.GetComponent<PrintDamage>();
        pd.change(d);


        if (mostrecentbullet != null || r.transform.parent.gameObject != null)
        {
            mostrecentbullet = r.transform.parent.gameObject;
        }

        currHealth -= d;
    }

/* public void PoisonedTick(float d, float t, GameObject g)
    {
        StartCoroutine(doT(d, t, g));
    }*/

    IEnumerator doT(float d, float t, GameObject g)
    {
        isPoisoned = true;
        int count = 0;
        while (count <= t)
        {
                yield return new WaitForSeconds(1);
                takeDamage((2 * d) / 3, g);
                count++;
        }
        isPoisoned = false;
    }

   void Die()
    {
        Turret xp = mostrecentbullet.gameObject.GetComponent<Turret>();
        xp.xp += xp2Give;
        Destroy(gameObject);
    }
}
