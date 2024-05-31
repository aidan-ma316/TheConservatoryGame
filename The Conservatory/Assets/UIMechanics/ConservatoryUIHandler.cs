using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConservatoryUIHandler : MonoBehaviour
{
    public GameObject ConMenuUI;
    public GameObject Button;

    public RangerMech rm;



    // Start is called before the first frame update
    void Start()
    {
        rm = GameObject.FindGameObjectWithTag("Player").GetComponent<RangerMech>(); ;
    }

    public void showUI()
    {
        if (rm.forUIBug != true)
        {
            ConMenuUI.SetActive(true);
        }
    }
    public void hideUI()
    {
     

        ConMenuUI.SetActive(false);


    }


}
