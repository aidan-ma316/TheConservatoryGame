using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMove : MonoBehaviour
{
    public float movespeed;

    public Paths pe;
    public Transform path;
    private int pathIndex = 0;

    

    void Start()
    {
        path = pe.t[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = path.position - transform.position;
        transform.Translate(dir.normalized * movespeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, path.position) <= .2f)
        {
            GetNextPath();
        }
    }

    void GetNextPath()
    {
        if (pathIndex >= pe.t.Length) { Destroy(gameObject); }

        pathIndex++;

        path = pe.t[pathIndex];
    }

    IEnumerator slowStun(float dec, float time)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

        float temp = movespeed;
        movespeed = movespeed * dec;
        int count = 0;
        while (count < time)
        {
            yield return new WaitForSeconds(.5f);
            count++;
        }
        movespeed = temp;
    }

    public void slowORStun(float dec, float time)
    {
        StartCoroutine(slowStun(dec, time));
    }
}
