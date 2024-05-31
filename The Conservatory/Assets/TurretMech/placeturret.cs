using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeturret : MonoBehaviour
{
    public GameObject turry;
    inventory invent;
    public bool placing = false;

    public GameObject tempdnd;

    GameObject tempo = null;

    // Update is called once per frame
    private void Start()
    {
       
        invent = GetComponent<inventory>(); ;
    }

    public void Update()
    {
        var bk = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (tempo != null)
        {
            if (placing == true) { 
            tempo.transform.position = new Vector3(bk.x, bk.y, 1f);
        } }

        if (Input.GetMouseButtonDown(0) && placing == true)
        {
            showPlacing(turry);

        }

        if (Input.GetMouseButtonUp(0) && placing == true)
        {
            place(turry);
            
        }
    }

    void place(GameObject turr)
    {
        Destroy(tempo);
        var ak = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        GameObject[] spawnplates = GameObject.FindGameObjectsWithTag("Node");
        Transform nearest = null;
        float shortest = Mathf.Infinity;

        foreach (GameObject spawnplate in spawnplates)
        {
            float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), spawnplate.transform.position);
            if (distance < shortest)
            {
                if (spawnplate.GetComponent<spawnnode>() !=null) {
                    shortest = distance;
                    nearest = spawnplate.transform;
                }
            }
        }

        if (Vector3.Distance(new Vector3(ak.x, ak.y, 0), nearest.transform.position) <= 10)
        {
            spawnnode sn = nearest.GetComponent<spawnnode>();
            if (sn.isOccupied == false) {
                sn.isOccupied = true;
                Instantiate(turr, new Vector3(nearest.position.x, nearest.position.y+.3f, 1f), transform.rotation);
                invent.subTurret(turry.GetComponent<Turret>());
            }
        }

        ///TutorialManager tut = (TutorialManager)FindObjectOfType(typeof(TutorialManager));
        //tut.Demolish()


        placing = false;
        invent.food -= 1;
    }

    void showPlacing(GameObject turry)
    {
       
        var ak = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        tempo = (GameObject)Instantiate(tempdnd, new Vector3(ak.x, ak.y + .3f, 1f), transform.rotation);




        SpriteRenderer mpsr = tempo.GetComponent<SpriteRenderer>();

        mpsr.sprite = turry.GetComponent<SpriteRenderer>().sprite;    

        Color tempc = tempo.GetComponent<SpriteRenderer>().color;
        tempc.a = 50f;
        mpsr.color= tempc;

        tempo.transform.position = new Vector3(ak.x, ak.y, 1f);

        
  }
}
