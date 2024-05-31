using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemy : MonoBehaviour
{
    public Transform Spawn1;
    public Transform Spawn2;
    public Transform Spawn3;
    public Transform Spawn4;
    public Transform Spawn5;
    public Transform Spawn6;
    public Transform Spawn7;
    public Transform Spawn8;

    public Paths Path1;
    public Paths Path2;
    public Paths Path3;
    public Paths Path4;
    public Paths Path5;
    public Paths Path6;
    public Paths Path7;
    public Paths Path8;

    public GameObject enemyUnit1;
    public GameObject enemyUnit2;
    public GameObject enemyUnit3;
    public GameObject enemyUnit4;

    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    public GameObject lit1;
    public GameObject lit2;
    public GameObject lit3;
    public GameObject lit4;

    public inventory invent;

    public GameObject button;

    public int wave;

    // Update is called once per frame
    void Update()
    {
        if (wave > 15) { SceneManager.LoadScene("Win"); }//load win scene
    }
    public void WaveManager()
    {
        if (wave == 1) wave1();
        else if (wave == 2) wave2();
        else if (wave == 3) wave3();
        else if (wave == 4) wave4();
        else if (wave == 5) wave5();
        else if (wave == 6) wave6();
        else if (wave == 7) wave7();
        else if (wave == 8) wave8();
        else if (wave == 9) wave9();
        else if (wave == 10) wave10();
        else if (wave == 11) wave11();
        else if (wave == 12) wave12();
        else if (wave == 13) wave13();
        else if (wave == 14) wave14();
        else if (wave == 15) wave15();
    }


    public void wave1()
    {
        StartCoroutine(wav1());
    }


    public void wave2()
    {
        StartCoroutine(wav2());
    }
    public void wave3()
    {
        StartCoroutine(wav3());
    }

    public void wave4()
    {
        StartCoroutine(wav4());
    }
    public void wave5()
    {
        StartCoroutine(wav5());
    }

    public void wave6()
    {
        StartCoroutine(wav6());
    }

    public void wave7()
    {
        StartCoroutine(wav7());
    }
    public void wave8()
    {
        StartCoroutine(wav8());
    }
    public void wave9()
    {
        StartCoroutine(wav9());
    }
    public void wave10()
    {
        StartCoroutine(wav10());
    }
    public void wave11()
    {
        StartCoroutine(wav11());
    }
    public void wave12()
    {
        StartCoroutine(wav12());
    }
    public void wave13()
    {
        StartCoroutine(wav13());
    }
    public void wave14()
    {
        StartCoroutine(wav14());
    }
    public void wave15()
    {
        StartCoroutine(wav15());
    }
  





    IEnumerator wav1()
    {
        button.SetActive(false);
        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit1, Spawn1);
        a.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit1, Spawn1);
        b.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(1f);
        GameObject c = Instantiate(enemyUnit1, Spawn1);
        c.GetComponent<UnitMove>().pe = Path1;


        giveXP(5);
        invent.addOM(3);
        yield return new WaitForSeconds(5f);
        wave++;
        button.SetActive(true);
    }

    IEnumerator wav2()
    {
        button.SetActive(false);


        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit1, Spawn1);
        a.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit1, Spawn1);
        b.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(1f);
        GameObject c = Instantiate(enemyUnit1, Spawn1);
        c.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit1, Spawn1);
        e.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject d = Instantiate(enemyUnit1, Spawn1);
        d.GetComponent<UnitMove>().pe = Path1;


        yield return new WaitForSeconds(4f);
        giveXP(10);
        invent.addOM(4);
        invent.addFood(1);
        wave++;
        

        rock1.SetActive(false);
        button.SetActive(true);

    }

    IEnumerator wav3()
    {
        button.SetActive(false);



        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit1, Spawn2);
        a.GetComponent<UnitMove>().pe = Path2;
        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit1, Spawn2);
        b.GetComponent<UnitMove>().pe = Path2;


        yield return new WaitForSeconds(1f);
        GameObject c = Instantiate(enemyUnit1, Spawn3);
        c.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit1, Spawn1);
        e.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject d = Instantiate(enemyUnit1, Spawn3);
        d.GetComponent<UnitMove>().pe = Path3;



        
        giveXP(7);
        invent.addOM(5);


        yield return new WaitForSeconds(5f);
        wave++;
        button.SetActive(true);


    }

    IEnumerator wav4()
    {
        button.SetActive(false);



        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit1, Spawn1);
        a.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit1, Spawn2);
        b.GetComponent<UnitMove>().pe = Path2;


        yield return new WaitForSeconds(1f);
        GameObject c = Instantiate(enemyUnit1, Spawn3);
        c.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit1, Spawn3);
        e.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject d = Instantiate(enemyUnit1, Spawn3);
        d.GetComponent<UnitMove>().pe = Path3;



        
        giveXP(7);
        invent.addOM(5);

        yield return new WaitForSeconds(5f);
        wave++;
        button.SetActive(true);
    }
    IEnumerator wav5()
    {
        button.SetActive(false);


        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit2, Spawn3);
        a.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit2, Spawn3);
        b.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(1f);
        GameObject c = Instantiate(enemyUnit1, Spawn3);
        c.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit1, Spawn3);
        e.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject d = Instantiate(enemyUnit1, Spawn3);
        d.GetComponent<UnitMove>().pe = Path3;


        yield return new WaitForSeconds(4f);
        giveXP(10);
        invent.addOM(5);
        invent.addFood(2);


        rock2.SetActive(false);
        lit1.SetActive(false);
        lit2.SetActive(true);
        cam2.SetActive(true);
        cam1.SetActive(false);
      


        yield return new WaitForSeconds(5f);
        button.SetActive(true);


        wave++;
    }




    IEnumerator wav6()
    {
        button.SetActive(false);


        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit2, Spawn1);
        a.GetComponent<UnitMove>().pe = Path1;
        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit2, Spawn3);
        b.GetComponent<UnitMove>().pe = Path3;


        yield return new WaitForSeconds(2f);
        GameObject c = Instantiate(enemyUnit1, Spawn2);
        c.GetComponent<UnitMove>().pe = Path3;
        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit1, Spawn2);
        e.GetComponent<UnitMove>().pe = Path3;


        yield return new WaitForSeconds(2f);
        GameObject d = Instantiate(enemyUnit1, Spawn4);
        d.GetComponent<UnitMove>().pe = Path4;
        yield return new WaitForSeconds(2f);
        GameObject f = Instantiate(enemyUnit1, Spawn4);
        f.GetComponent<UnitMove>().pe = Path4;
        yield return new WaitForSeconds(2f);
        GameObject g = Instantiate(enemyUnit1, Spawn4);
        g.GetComponent<UnitMove>().pe = Path4;

        yield return new WaitForSeconds(4f);
        giveXP(15);
        invent.addOM(5);
        invent.addFood(2);



        yield return new WaitForSeconds(5f);
        button.SetActive(true);


        wave++;
    }


    IEnumerator wav7()
    {
        button.SetActive(false);

        //four on four (2 high level)
        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit2, Spawn4);
        a.GetComponent<UnitMove>().pe = Path4;

        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit1, Spawn4);
        b.GetComponent<UnitMove>().pe = Path4;

        GameObject g = Instantiate(enemyUnit1, Spawn2);
        g.GetComponent<UnitMove>().pe = Path2;



        yield return new WaitForSeconds(2f);
        GameObject c = Instantiate(enemyUnit2, Spawn4);
        c.GetComponent<UnitMove>().pe = Path4;

        GameObject x = Instantiate(enemyUnit1, Spawn3);
        x.GetComponent<UnitMove>().pe = Path3;


        yield return new WaitForSeconds(2f);
        GameObject d = Instantiate(enemyUnit1, Spawn4);
        d.GetComponent<UnitMove>().pe = Path4;

        GameObject h = Instantiate(enemyUnit1, Spawn2);
        h.GetComponent<UnitMove>().pe = Path2;


        //one leve3 robo

        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit3, Spawn1);
        e.GetComponent<UnitMove>().pe = Path1;

        yield return new WaitForSeconds(2f);

        GameObject f = Instantiate(enemyUnit1, Spawn3);
        f.GetComponent<UnitMove>().pe = Path3;

        //4 level 1 robo on 2/3





        giveXP(20);
        invent.addOM(5);
        yield return new WaitForSeconds(5f);
        button.SetActive(true);
        wave++;
    }

    IEnumerator wav8()
    {
        button.SetActive(false);

        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit3, Spawn1);
        e.GetComponent<UnitMove>().pe = Path1;


        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit1, Spawn2);
        a.GetComponent<UnitMove>().pe = Path2;


        yield return new WaitForSeconds(2f);
        GameObject b = Instantiate(enemyUnit1, Spawn3);
        b.GetComponent<UnitMove>().pe = Path3;

        GameObject f = Instantiate(enemyUnit3, Spawn1);
        f.GetComponent<UnitMove>().pe = Path1;


        yield return new WaitForSeconds(2f);

        GameObject x = Instantiate(enemyUnit2, Spawn4);
        x.GetComponent<UnitMove>().pe = Path4;

        //2 level 3 robo 1

        //1 on 2/3

        //level 2 on route 4







        giveXP(30);
        invent.addOM(5);
        invent.addFood(2);
        yield return new WaitForSeconds(6f);

        rock3.SetActive(false);
        lit2.SetActive(false);
        lit3.SetActive(true);
       
        cam3.SetActive(true);
        cam2.SetActive(false);



        button.SetActive(true);
        wave++;
    }




    IEnumerator wav9()
    {
        button.SetActive(false);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn6, Path6);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit3, Spawn1, Path1);
        Create(enemyUnit3, Spawn3, Path3);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn6, Path6);
        Create(enemyUnit1, Spawn5, Path5);
        Create(enemyUnit2, Spawn3, Path3);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn6, Path6);
        Create(enemyUnit1, Spawn5, Path5);


        yield return new WaitForSeconds(2f);
        GameObject e = Instantiate(enemyUnit3, Spawn1);
        e.GetComponent<UnitMove>().pe = Path1;


        yield return new WaitForSeconds(2f);
        GameObject a = Instantiate(enemyUnit1, Spawn2);
        a.GetComponent<UnitMove>().pe = Path2;



        giveXP(20);
        invent.addOM(5);
        invent.addFood(1);
        yield return new WaitForSeconds(5f);
        button.SetActive(true);
        wave++;
    }




    IEnumerator wav10()
    {
        button.SetActive(false);

        //2 level 2 on path 5/6
        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn5, Path5);

      

        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn6, Path6);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit3, Spawn1, Path1);
        Create(enemyUnit3, Spawn3, Path3);

        yield return new WaitForSeconds(2f);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit3, Spawn2, Path2);
        //1 level 3 path one/2/3
        //1 level 2 / 2 level ones on path 4

        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn4, Path4);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn4, Path4);





        giveXP(15);
        invent.addOM(5);
        invent.addFood(2);
        yield return new WaitForSeconds(5f);
        button.SetActive(true);
        wave++;
    }


    IEnumerator wav11()
    {
        button.SetActive(false);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn6, Path6);
        Create(enemyUnit1, Spawn5, Path5);
        Create(enemyUnit2, Spawn3, Path3);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn6, Path6);
        Create(enemyUnit1, Spawn5, Path5);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn6, Path6);
        Create(enemyUnit1, Spawn5, Path5);
        Create(enemyUnit2, Spawn1, Path1);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn6, Path6);
        Create(enemyUnit1, Spawn5, Path5);
        Create(enemyUnit2, Spawn2, Path2);



        //1 level 2 / 2 level ones on path 4

        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn4, Path4);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn4, Path4);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn4, Path4);


        yield return new WaitForSeconds(5f);
        giveXP(15);
        invent.addOM(5);
        invent.addFood(2);

        rock4.SetActive(false);
        lit3.SetActive(false);
        lit4.SetActive(true);


        button.SetActive(true);
        wave++;
    }


    IEnumerator wav12()
    {
        button.SetActive(false);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn7, Path7);
        Create(enemyUnit1, Spawn8, Path8);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn7, Path7);
        Create(enemyUnit1, Spawn8, Path8);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn7, Path7);
        Create(enemyUnit1, Spawn8, Path8);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn7, Path7);
        Create(enemyUnit1, Spawn8, Path8);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn7, Path7);
        Create(enemyUnit1, Spawn8, Path8);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn8, Path8);
        Create(enemyUnit1, Spawn7, Path7);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn8, Path8);
        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn7, Path7);





        giveXP(15);
        invent.addOM(5);
        invent.addFood(5);
        yield return new WaitForSeconds(5f);
        button.SetActive(true);
        wave++;
    }

    IEnumerator wav13()
    {
        button.SetActive(false);

        //4 level ones on each path
        //1 level 2 each path
        //1 level 3 each path
        yield return new WaitForSeconds(2f);

        GameObject a1 = Instantiate(enemyUnit1, Spawn1);
        a1.GetComponent<UnitMove>().pe = Path1;

        GameObject a11 = Instantiate(enemyUnit1, Spawn2);
        a11.GetComponent<UnitMove>().pe = Path2;


        GameObject a111 = Instantiate(enemyUnit1, Spawn4);
        a111.GetComponent<UnitMove>().pe = Path4;


        GameObject a1111 = Instantiate(enemyUnit1, Spawn5);
        a1111.GetComponent<UnitMove>().pe = Path5;


        GameObject a11111 = Instantiate(enemyUnit1, Spawn8);
        a11111.GetComponent<UnitMove>().pe = Path8;


        yield return new WaitForSeconds(2f);
        GameObject a2 = Instantiate(enemyUnit1, Spawn1);
        a2.GetComponent<UnitMove>().pe = Path1;

        GameObject a12 = Instantiate(enemyUnit1, Spawn2);
        a12.GetComponent<UnitMove>().pe = Path2;

        GameObject a112 = Instantiate(enemyUnit1, Spawn4);
        a112.GetComponent<UnitMove>().pe = Path4;


        GameObject a1112 = Instantiate(enemyUnit1, Spawn6);
        a1112.GetComponent<UnitMove>().pe = Path6;


        GameObject a11112 = Instantiate(enemyUnit1, Spawn7);
        a11112.GetComponent<UnitMove>().pe = Path7;


        yield return new WaitForSeconds(2f);
        GameObject a3 = Instantiate(enemyUnit1, Spawn1);
        a3.GetComponent<UnitMove>().pe = Path1;



        GameObject a13 = Instantiate(enemyUnit1, Spawn2);
        a13.GetComponent<UnitMove>().pe = Path2;


        GameObject a113 = Instantiate(enemyUnit1, Spawn4);
        a113.GetComponent<UnitMove>().pe = Path4;


        GameObject a1113 = Instantiate(enemyUnit1, Spawn5);
        a1113.GetComponent<UnitMove>().pe = Path5;


        GameObject a11113 = Instantiate(enemyUnit1, Spawn7);
        a11113.GetComponent<UnitMove>().pe = Path7;



        yield return new WaitForSeconds(2f);
        GameObject a4 = Instantiate(enemyUnit1, Spawn1);
        a4.GetComponent<UnitMove>().pe = Path1;

        GameObject a14 = Instantiate(enemyUnit1, Spawn2);
        a14.GetComponent<UnitMove>().pe = Path2;

        GameObject a114= Instantiate(enemyUnit1, Spawn4);
        a114.GetComponent<UnitMove>().pe = Path4;

        GameObject a1114 = Instantiate(enemyUnit1, Spawn6);
        a1114.GetComponent<UnitMove>().pe = Path6;

        GameObject a11114 = Instantiate(enemyUnit1, Spawn8);
        a11114.GetComponent<UnitMove>().pe = Path8;



        yield return new WaitForSeconds(2f);

        GameObject b1 = Instantiate(enemyUnit2, Spawn1);
        b1.GetComponent<UnitMove>().pe = Path1;

        GameObject b2 = Instantiate(enemyUnit2, Spawn2);
        b2.GetComponent<UnitMove>().pe = Path2;

        GameObject b3 = Instantiate(enemyUnit2, Spawn3);
        b3.GetComponent<UnitMove>().pe = Path3;

        GameObject b4 = Instantiate(enemyUnit2, Spawn4);
        b4.GetComponent<UnitMove>().pe = Path4;

        GameObject b5 = Instantiate(enemyUnit2, Spawn5);
        b5.GetComponent<UnitMove>().pe = Path5;

        GameObject b6 = Instantiate(enemyUnit2, Spawn6);
        b6.GetComponent<UnitMove>().pe = Path6;

        GameObject b7 = Instantiate(enemyUnit2, Spawn7);
        b7.GetComponent<UnitMove>().pe = Path7;

        GameObject b8 = Instantiate(enemyUnit2, Spawn8);
        b8.GetComponent<UnitMove>().pe = Path8;



        yield return new WaitForSeconds(4f);
        GameObject c1 = Instantiate(enemyUnit3, Spawn1);
        c1.GetComponent<UnitMove>().pe = Path1;

        GameObject c2 = Instantiate(enemyUnit3, Spawn2);
        c2.GetComponent<UnitMove>().pe = Path2;

        GameObject c3 = Instantiate(enemyUnit3, Spawn3);
        c3.GetComponent<UnitMove>().pe = Path3;

        GameObject c4 = Instantiate(enemyUnit3, Spawn4);
        c4.GetComponent<UnitMove>().pe = Path4;

        GameObject c5 = Instantiate(enemyUnit3, Spawn5);
        c5.GetComponent<UnitMove>().pe = Path5;

        GameObject c6 = Instantiate(enemyUnit3, Spawn6);
        c6.GetComponent<UnitMove>().pe = Path6;

        GameObject c7 = Instantiate(enemyUnit3, Spawn7);
        c7.GetComponent<UnitMove>().pe = Path7;

        GameObject c8 = Instantiate(enemyUnit3, Spawn8);
        c8.GetComponent<UnitMove>().pe = Path8;



        giveXP(15);
        invent.addFood(3);
        invent.addOM(5);
        yield return new WaitForSeconds(5f);
        button.SetActive(true);
        wave++;
    }
    IEnumerator wav14()
    {
        button.SetActive(false);

        //3 level 3s each path

        yield return new WaitForSeconds(2f);
        GameObject c1 = Instantiate(enemyUnit3, Spawn1);
        c1.GetComponent<UnitMove>().pe = Path1;

        GameObject c2 = Instantiate(enemyUnit3, Spawn2);
        c2.GetComponent<UnitMove>().pe = Path2;

        GameObject c3 = Instantiate(enemyUnit3, Spawn3);
        c3.GetComponent<UnitMove>().pe = Path3;

        GameObject c4 = Instantiate(enemyUnit3, Spawn4);
        c4.GetComponent<UnitMove>().pe = Path4;

        GameObject c5 = Instantiate(enemyUnit3, Spawn5);
        c5.GetComponent<UnitMove>().pe = Path5;

        GameObject c6 = Instantiate(enemyUnit3, Spawn6);
        c6.GetComponent<UnitMove>().pe = Path6;

        GameObject c7 = Instantiate(enemyUnit3, Spawn7);
        c7.GetComponent<UnitMove>().pe = Path7;

        GameObject c8 = Instantiate(enemyUnit3, Spawn8);
        c8.GetComponent<UnitMove>().pe = Path8;


        yield return new WaitForSeconds(2f);
        GameObject a1 = Instantiate(enemyUnit3, Spawn1);
        a1.GetComponent<UnitMove>().pe = Path1;

        GameObject a2 = Instantiate(enemyUnit3, Spawn2);
        a2.GetComponent<UnitMove>().pe = Path2;

        GameObject a3 = Instantiate(enemyUnit3, Spawn3);
        a3.GetComponent<UnitMove>().pe = Path3;

        GameObject a4 = Instantiate(enemyUnit3, Spawn4);
        a4.GetComponent<UnitMove>().pe = Path4;

        GameObject a5 = Instantiate(enemyUnit3, Spawn5);
        a5.GetComponent<UnitMove>().pe = Path5;

        GameObject a6 = Instantiate(enemyUnit3, Spawn6);
        a6.GetComponent<UnitMove>().pe = Path6;

        GameObject a7 = Instantiate(enemyUnit3, Spawn7);
        a7.GetComponent<UnitMove>().pe = Path7;

        GameObject a8 = Instantiate(enemyUnit3, Spawn8);
        a8.GetComponent<UnitMove>().pe = Path8;


        yield return new WaitForSeconds(2f);
        GameObject d1 = Instantiate(enemyUnit3, Spawn1);
        d1.GetComponent<UnitMove>().pe = Path1;

        GameObject d2 = Instantiate(enemyUnit3, Spawn2);
        d2.GetComponent<UnitMove>().pe = Path2;

        GameObject d3 = Instantiate(enemyUnit3, Spawn3);
        d3.GetComponent<UnitMove>().pe = Path3;

        GameObject d4 = Instantiate(enemyUnit3, Spawn4);
        d4.GetComponent<UnitMove>().pe = Path4;

        GameObject d5 = Instantiate(enemyUnit3, Spawn5);
        d5.GetComponent<UnitMove>().pe = Path5;

        GameObject d6 = Instantiate(enemyUnit3, Spawn6);
        d6.GetComponent<UnitMove>().pe = Path6;

        GameObject d7 = Instantiate(enemyUnit3, Spawn7);
        d7.GetComponent<UnitMove>().pe = Path7;

        GameObject d8 = Instantiate(enemyUnit3, Spawn8);
        d8.GetComponent<UnitMove>().pe = Path8;





        giveXP(50);
        invent.addOM(5);
        invent.addFood(2);
        yield return new WaitForSeconds(5f);
        button.SetActive(true);
        wave++;
    }

    IEnumerator wav15()
    {
        button.SetActive(false);

        //3 level 3s each path
        yield return new WaitForSeconds(2f);
        GameObject c1 = Instantiate(enemyUnit3, Spawn1);
        c1.GetComponent<UnitMove>().pe = Path1;

        GameObject c2 = Instantiate(enemyUnit3, Spawn2);
        c2.GetComponent<UnitMove>().pe = Path2;

        GameObject c3 = Instantiate(enemyUnit3, Spawn3);
        c3.GetComponent<UnitMove>().pe = Path3;

        GameObject c4 = Instantiate(enemyUnit3, Spawn4);
        c4.GetComponent<UnitMove>().pe = Path4;

        GameObject c5 = Instantiate(enemyUnit3, Spawn5);
        c5.GetComponent<UnitMove>().pe = Path5;

        GameObject c6 = Instantiate(enemyUnit3, Spawn6);
        c6.GetComponent<UnitMove>().pe = Path6;

        GameObject c7 = Instantiate(enemyUnit3, Spawn7);
        c7.GetComponent<UnitMove>().pe = Path7;

        GameObject c8 = Instantiate(enemyUnit3, Spawn8);
        c8.GetComponent<UnitMove>().pe = Path8;


        yield return new WaitForSeconds(2f);
        GameObject a1 = Instantiate(enemyUnit3, Spawn1);
        a1.GetComponent<UnitMove>().pe = Path1;

        GameObject a2 = Instantiate(enemyUnit3, Spawn2);
        a2.GetComponent<UnitMove>().pe = Path2;

        GameObject a3 = Instantiate(enemyUnit3, Spawn3);
        a3.GetComponent<UnitMove>().pe = Path3;

        GameObject a4 = Instantiate(enemyUnit3, Spawn4);
        a4.GetComponent<UnitMove>().pe = Path4;

        GameObject a5 = Instantiate(enemyUnit3, Spawn5);
        a5.GetComponent<UnitMove>().pe = Path5;

        GameObject a6 = Instantiate(enemyUnit3, Spawn6);
        a6.GetComponent<UnitMove>().pe = Path6;

        GameObject a7 = Instantiate(enemyUnit3, Spawn7);
        a7.GetComponent<UnitMove>().pe = Path7;

        GameObject a8 = Instantiate(enemyUnit3, Spawn8);
        a8.GetComponent<UnitMove>().pe = Path8;


        yield return new WaitForSeconds(2f);
        GameObject d1 = Instantiate(enemyUnit3, Spawn1);
        d1.GetComponent<UnitMove>().pe = Path1;

        GameObject d2 = Instantiate(enemyUnit3, Spawn2);
        d2.GetComponent<UnitMove>().pe = Path2;

        GameObject d3 = Instantiate(enemyUnit3, Spawn3);
        d3.GetComponent<UnitMove>().pe = Path3;

        GameObject d4 = Instantiate(enemyUnit3, Spawn4);
        d4.GetComponent<UnitMove>().pe = Path4;

        GameObject d5 = Instantiate(enemyUnit3, Spawn5);
        d5.GetComponent<UnitMove>().pe = Path5;

        GameObject d6 = Instantiate(enemyUnit3, Spawn6);
        d6.GetComponent<UnitMove>().pe = Path6;

        GameObject d7 = Instantiate(enemyUnit3, Spawn7);
        d7.GetComponent<UnitMove>().pe = Path7;

        GameObject d8 = Instantiate(enemyUnit3, Spawn8);
        d8.GetComponent<UnitMove>().pe = Path8;



        // 5 level 2s each path
        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn1, Path1);

        Create(enemyUnit2, Spawn2, Path2);

        Create(enemyUnit2, Spawn3, Path3);

        Create(enemyUnit2, Spawn4, Path4);

        Create(enemyUnit2, Spawn5, Path5);

        Create(enemyUnit2, Spawn6, Path6);

        Create(enemyUnit2, Spawn7, Path7);

        Create(enemyUnit2, Spawn8, Path8);



        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn1, Path1);

        Create(enemyUnit2, Spawn2, Path2);

        Create(enemyUnit2, Spawn3, Path3);

        Create(enemyUnit2, Spawn4, Path4);

        Create(enemyUnit2, Spawn5, Path5);

        Create(enemyUnit2, Spawn6, Path6);

        Create(enemyUnit2, Spawn7, Path7);

        Create(enemyUnit2, Spawn8, Path8);


        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn1, Path1);

        Create(enemyUnit2, Spawn2, Path2);

        Create(enemyUnit2, Spawn3, Path3);

        Create(enemyUnit2, Spawn4, Path4);

        Create(enemyUnit2, Spawn5, Path5);

        Create(enemyUnit2, Spawn6, Path6);

        Create(enemyUnit2, Spawn7, Path7);

        Create(enemyUnit2, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn1, Path1);

        Create(enemyUnit2, Spawn2, Path2);

        Create(enemyUnit2, Spawn3, Path3);

        Create(enemyUnit2, Spawn4, Path4);

        Create(enemyUnit2, Spawn5, Path5);

        Create(enemyUnit2, Spawn6, Path6);

        Create(enemyUnit2, Spawn7, Path7);

        Create(enemyUnit2, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit2, Spawn1, Path1);

        Create(enemyUnit2, Spawn2, Path2);

        Create(enemyUnit2, Spawn3, Path3);

        Create(enemyUnit2, Spawn4, Path4);

        Create(enemyUnit2, Spawn5, Path5);

        Create(enemyUnit2, Spawn6, Path6);

        Create(enemyUnit2, Spawn7, Path7);

        Create(enemyUnit2, Spawn8, Path8);



        //7 level ones each path

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);

        yield return new WaitForSeconds(2f);
        Create(enemyUnit1, Spawn1, Path1);

        Create(enemyUnit1, Spawn2, Path2);

        Create(enemyUnit1, Spawn3, Path3);

        Create(enemyUnit1, Spawn4, Path4);

        Create(enemyUnit1, Spawn5, Path5);

        Create(enemyUnit1, Spawn6, Path6);

        Create(enemyUnit1, Spawn7, Path7);

        Create(enemyUnit1, Spawn8, Path8);




        giveXP(15);
        invent.addOM(5);
        invent.addFood(10);
        yield return new WaitForSeconds(20f);
        button.SetActive(true);
        wave++;
    }


    



    void giveXP(int num)
    {
        GameObject[] Turrets = GameObject.FindGameObjectsWithTag("Turret");

        foreach (GameObject Turr in Turrets)
            {
            Turr.GetComponent<Turret>().xp += num;
            }
    }





    void Create(GameObject enemy, Transform spawn, Paths path)
    {
        GameObject a = Instantiate(enemy, spawn);
        a.GetComponent<UnitMove>().pe = path;
    }
}
