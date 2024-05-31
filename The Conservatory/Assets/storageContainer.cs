using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class storageContainer : MonoBehaviour
{
    public Camera storage;
    private bool ismouse = false;
    public RectTransform rect;
    public RectTransformUtility rect1;
    private Vector3 [] Corners;
    public GameObject test;

    public placeturret pt;

    public GameObject ConMenuUI;

    public int numMons = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMouseOver()
    {
        if (numMons > 0)
        {
            //GameObject testing = (GameObject) Instantiate(test);


            var ak = Camera.main.ScreenToWorldPoint(Input.mousePosition);




            ak.x += 16f;
            ak.y += 24;

            //testing.transform.position = ak;
            //testing.transform.localScale = 2 * testing.transform.localScale;

            GameObject nearest = null;
            float shortest = Mathf.Infinity;


            storedMonster[] monsters = storedMonster.FindObjectsOfType<storedMonster>();

            foreach (storedMonster monster in monsters)
            {
                float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), monster.transform.position);
                if (distance < shortest)
                {
                    //if (distance <= 5)
                    {
                        shortest = distance;
                        nearest = monster.gameObject;
                        Debug.Log(monster.gameObject.transform.position);
                    }
                }
            }
            if (nearest != null)
            {
                pt.turry = nearest.GetComponent<storedMonster>().turry;
                pt.placing = true;
                ConMenuUI.GetComponent<ConservatoryUIHandler>().hideUI();
                nearest.SetActive(false);
            }
            //TutorialManager tut = (TutorialManager)FindObjectOfType(typeof(TutorialManager));
            //tut.showUI();


        }
    }   
}

