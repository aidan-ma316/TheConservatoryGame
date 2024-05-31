using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public GameObject PLAYER;
    public GameObject CAMERA;
    private Vector3 coords;

    void Awake()
    {
        coords.z = -10;
    }
    // Update is called once per frame

    void Update()
    {
        coords.x = (PLAYER.GetComponent<Transform>().position.x);
        coords.y = (PLAYER.GetComponent<Transform>().position.y);

        CAMERA.GetComponent<Transform>().SetPositionAndRotation(coords, CAMERA.GetComponent<Transform>().rotation);
    }
}