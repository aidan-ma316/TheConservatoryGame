using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBuilder : MonoBehaviour
{
    public GameObject toPlace;
    public GameObject terrain;

    int layer;


    public static bool bought;
    public bool placing;

    public GameObject ice;
    public GameObject lava;
    public GameObject desert;

    public BuildMenu bm;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        placeState();
    }

   public void changeTerrain(GameObject s)
    {
        var ak = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y - 16f));

        GameObject[] spawnplates = GameObject.FindGameObjectsWithTag("Node");
        GameObject nearest = null;
        float shortest = Mathf.Infinity;

        Vector3 t = transform.position;
 
        foreach (GameObject spawnplate in spawnplates)
        {
            float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), spawnplate.transform.position);
            if (distance < shortest)
            {
                shortest = distance;
                nearest = spawnplate;
                layer = nearest.GetComponent<SpriteRenderer>().sortingOrder;
                t = nearest.transform.position;
            }
        }

        nearest.SetActive(false);
        s.GetComponent<SpriteRenderer>().sortingOrder = layer;
        Instantiate(s, t, s.transform.rotation);

    }

    public void PlaceIce()
    {
            toPlace = ice;
    }

    public void PlaceLava()
    {
        toPlace = lava;
    }

    public void PlaceDesert()
    {
        toPlace = desert;
    }

    public void placeState()
    {
        if (placing == true)
        {
            if (Input.GetKeyDown("escape")) { placing = false; }
            if (Input.GetMouseButtonDown(0)) { changeTerrain(toPlace); placing = false; }
        }
    }





}
