using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class evolutionUI : MonoBehaviour
{
    public Image im1;
    public Image im2;

    public Button b1;
    public Button b2;
    


    public void hideUI() { gameObject.GetComponent<RectTransform>().localScale = new Vector3(0.001f, 0.001f); }
}
