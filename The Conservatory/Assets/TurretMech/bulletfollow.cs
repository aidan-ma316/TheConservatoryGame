using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfollow : MonoBehaviour
{
    protected Transform target;
    public float speed = .5f;
    protected Vector3 dir;

    public Animator Miyazaki;

    public float damage = 5f;

    public void getTarget(Transform t, float d)
    {
        target = t;
        damage = d;
    }

    public void Start()
    {
        dir = target.position - transform.position;
        Miyazaki = GetComponent<Animator>();
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
        Destroy(gameObject);
    }
}
