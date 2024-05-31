using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMonster : MonoBehaviour
{
    public bool hasSpawned;
    public GameObject monsterToSpawn;
    public GameObject rangerNotif;

    public TutorialManager tut;
    GameObject temp;

    bool tamed = false;



    public float timeToSpawn;

    void Start()
    {
        hasSpawned = false;
        StartCoroutine(spawnTimer(timeToSpawn));
        //tut = (TutorialManager)FindObjectOfType(typeof(TutorialManager));
    }

    IEnumerator spawnTimer(float t)
    {
        yield return new WaitForSeconds(t);
        Instantiate(monsterToSpawn, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .32f, gameObject.transform.position.z), gameObject.transform.rotation);
        hasSpawned = true;
        ///tut.showUI(); //FOR TUTORIAL NEEDS FIXING


        Instantiate(rangerNotif, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .64f, gameObject.transform.position.z), gameObject.transform.rotation);
        GameObject b = (GameObject)Instantiate(rangerNotif, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .64f, gameObject.transform.position.z), gameObject.transform.rotation);
        temp = b;
    }

    public void destroyThese()
    {
        Destroy(temp);
        Destroy(monsterToSpawn);
    }

}
