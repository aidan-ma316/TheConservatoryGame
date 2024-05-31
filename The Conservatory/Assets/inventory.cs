using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventory : MonoBehaviour
{
    private List<Turret> tList;
    public GameObject tur;


    public int food;
    public int OrganicMatter;

    private void Start()
    {
    }

    public List<Turret> gettList()
    {
        return tList;
    }

    public void addFood(int inc) { food += inc; }
    public void subFood(int dec) { food -= dec;  }

    public void addOM(int inc) { OrganicMatter += inc; }
    public void subOM(int dec) { OrganicMatter -= dec; }
    public int gettListLength()
    {
        return tList.Count;
    }

    public inventory()
    {
        tList = new List<Turret>();
    }

    public void addTurret(Turret t) {
        tList.Add(t);
    }

    public void subTurret(Turret t)
    {
        tList.Remove(t);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
