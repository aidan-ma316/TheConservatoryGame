using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerMech : MonoBehaviour
{
    public bool taming;
    public bool forUIBug;
    bool tamed = false;
    int count = 0;

    public inventory inv;

    public ConservatoryUIHandler conUI;

    Turret t;

    GameObject monsterToTame;
    GameObject notifToDestroy;

    

    void Update()
    {
        tameState();  
    }

    void tameMonster()
    {
       
        var ak = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y - 16f));

        GameObject[] monsters = GameObject.FindGameObjectsWithTag("TameableMonster");
        GameObject nearest = null;
        float shortest = Mathf.Infinity;

        foreach (GameObject monster in monsters)
        {
            float distance = Vector3.Distance(new Vector3(ak.x, ak.y, 0), monster.transform.position);
            if (distance < shortest)
            {
                    shortest = distance;
                    nearest = monster;
            }
        }
        if (nearest != null)
        {
            monsterToTame = nearest;
            taming = false;
            count = 0;
            InvokeRepeating("tameTimer", 0f, 1f);
        }
    }

    public void tameState()
    {
        if (taming == true)
        {
            Debug.Log("Tame state");
            if (Input.GetKeyDown("escape")) { taming = false; inv.addFood(1); }
            if (Input.GetMouseButtonDown(0)) { tamed = false; tameMonster(); }
        }
    }

    void tameTimer() { 
        if(tamed == false)
        {
            taming = false;
            forUIBug = true;
            if (count < 5)
            {
                Debug.Log("Taming");
                count++;
            }
            if (count >= 5)
            {
                Debug.Log("Tamed");
                Destroy(monsterToTame);
                //inv.addTurret(t);
                //TutorialManager tut = (TutorialManager)FindObjectOfType(typeof(TutorialManager)); tut.showUI();
                Instantiate(monsterToTame.GetComponent<tameablemonster>().monsteraftertame, new Vector3(24, 24, 0), transform.rotation);
                storageContainer sc = (storageContainer)FindObjectOfType(typeof (storageContainer)); sc.numMons++;

                Destroy(notifToDestroy);
                tamed = true;
                forUIBug = false;
               
            }
            
        }
    }


    public void checkCost()
    {
        if (inv.food >= 1)
        {
            inv.food -= 1;
            taming = true;
            conUI.hideUI();
        }
    }



}
