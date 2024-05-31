using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsoPlayerMovement : MonoBehaviour
{
    private Rigidbody2D PlayerRB;
    private Vector2 PlayerMovement;
    public float movespeed = 2f;
    public Camera main;
    public int camControl = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        main = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Zoom();
    }


    void Zoom()
    {
        var scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f && camControl <= 2)
        {
            main.orthographicSize--;
            camControl++;
        } else if (scroll < 0f && camControl >= -2)
        {
            main.orthographicSize++;
            camControl--;
        }
    }


    public void Move()
    {
        PlayerMovement.x = Input.GetAxis("Horizontal");
        PlayerMovement.y = Input.GetAxis("Vertical");
        PlayerRB.MovePosition(PlayerRB.position + PlayerMovement * movespeed * Time.deltaTime);


    }
}
