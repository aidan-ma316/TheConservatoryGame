using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodcounter : MonoBehaviour
{
    GameObject inv;
    TextMeshProUGUI food;
    public TextMeshProUGUI OM;
    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Player");
        food = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        food.SetText(inv.GetComponent<inventory>().food.ToString());
        OM.SetText(inv.GetComponent<inventory>().OrganicMatter.ToString());
    }
}
