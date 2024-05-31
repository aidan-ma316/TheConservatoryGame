using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

    public GameObject currentLight;

    private void Update()
    {
        getCurrent();
    }

    void getCurrent()
    {
        if (Light1.activeSelf == true) { currentLight = Light1; }
        if (Light2.activeSelf == true) { currentLight = Light2; }
        if (Light3.activeSelf == true) { currentLight = Light3; }
    }


    void switchLight()
    {
        if(currentLight == Light1)
        {
            Light1.SetActive(false);
            Light2.SetActive(true);
        }
        else if (currentLight == Light2)
        {
            Light1.SetActive(false);
            Light3.SetActive(true);
        }
    }
}
