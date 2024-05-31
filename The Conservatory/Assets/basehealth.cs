using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class basehealth : MonoBehaviour
{
    float maxhealth = 10f;
    public float currenthealth;
    public Image slide;

 


    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
        slide.fillAmount = currenthealth/maxhealth;
        // text.text = currenthealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        slide.fillAmount = currenthealth / maxhealth;

        if (currenthealth <= 0) { SceneManager.LoadScene("GameOver"); }




    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        currenthealth -= 1f;
      
        //text.text = currenthealth.ToString();
        Destroy(collision.gameObject);
    }
}
