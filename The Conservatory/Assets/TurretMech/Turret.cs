using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    private GameObject g;
    public TurretType type;
    public int num;

    public int xp = 0;
    public int level = 1;
    public int maxlevel = 10;

    public int xpToLevel;

    public Sprite evo1;
    public Sprite evo2;


    public bool canEvolve;
    public bool hasEvolved;

    public GameObject evolvePanel;

    public Canvas can;

    public int evo = 1;

    public bool check;


    public enum TurretType
    {
        fire,
        earth,
        ice
    }
    // Start is called before the first frame update
    void Start()
    {
        
        g = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        evolvePanel = GameObject.FindGameObjectWithTag("Evolve");

        xpToLevel = (level * 10) + 5;

        if (xp >= xpToLevel && level < maxlevel) { level++; }

        if (level >= 10 && hasEvolved == false)
        {
            canEvolve = true;
            hasEvolved = true;
        }

        if (canEvolve == true)
        {
            canEvolve = false;
            evolvUI();
        }

        spriteChange();

    }


    void evolvUI()
    {

            evolvePanel.GetComponent<RectTransform>().localScale = new Vector3(0.5f, 0.5f);

            evolutionUI eui;
            eui = evolvePanel.GetComponent<evolutionUI>();



            eui.im1.sprite = evo1;
            eui.im2.sprite = evo2;

            eui.b1.onClick.AddListener(evol1);
            eui.b1.onClick.AddListener(eui.hideUI);
            eui.b2.onClick.AddListener(evol2);
            eui.b2.onClick.AddListener(eui.hideUI);

    }


    void spriteChange()
    {
        if (evo == 2)
        {
            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            transform.localScale = (new Vector3(.5f, .5f));
            sr.sprite = evo1;

        }

        if (evo == 3)
        {
            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            transform.localScale = (new Vector3(.5f, .5f));
            sr.sprite = evo2;

        }


    }


    void evol1()
    {
        if (check == false)
        {
            evo = 2;


            evolvePanel.GetComponent<RectTransform>().localScale = new Vector3(0f, 0f);
            check = true;
        }
    }


    void evol2()
    {
        if (check == false)
        {
            evo = 3;
            evolvePanel.GetComponent<RectTransform>().localScale = new Vector3(0f, 0f);
            check = true;
        }
    }
}



