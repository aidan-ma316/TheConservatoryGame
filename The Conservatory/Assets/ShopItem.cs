using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public int cost;
    inventory playerOM;
    TerrainBuilder tb;
    public static bool bought;
    public BuildMenu bm;


    void Start()
    {
        bought = false;
        playerOM = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        tb = GameObject.FindGameObjectWithTag("Player").GetComponent <TerrainBuilder>();
    }

    public void checkCost()
    {
        if (playerOM.OrganicMatter >= cost)
        {
            bought = true;
            playerOM.OrganicMatter -= cost;
            tb.placing = true;
            bm.hideUI();
        }
    }
}
