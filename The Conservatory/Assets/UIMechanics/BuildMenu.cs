using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public GameObject BuildMenuUI;
    public GameObject Button;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void showUI()
    {

        BuildMenuUI.SetActive(true);

    }
    public void hideUI()
    {

        BuildMenuUI.SetActive(false);


    }


}
