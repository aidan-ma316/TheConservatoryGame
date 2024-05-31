using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static bool isPaused;
    public GameObject UI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            if (isPaused == true)
            {
                UI.SetActive(false);
            }
            else UI.SetActive(true);


        }





    }
}
