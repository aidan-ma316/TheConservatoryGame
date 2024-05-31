using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mouseOverUI : MonoBehaviour
{   
    private bool ismouse = false;
    public bool inMenu = false;
    private void OnPointerEnter(PointerEventData eventData)
    {
        ismouse = true;
    }
    private void OnPointerExit(PointerEventData eventData)
    {
        ismouse = false;
    }

    private void Update()
    {
        if (ismouse == true)
        {
            gameObject.GetComponent<RectTransform>().transform.Translate(new Vector3(0f, 100f, 0f));
        }
    }

    public void up()
    {
        if (inMenu == false)
        {
            gameObject.GetComponent<RectTransform>().transform.Translate(new Vector3(0f, 25f, 0f));
        }
    }

    public void down()
    {
        if (inMenu == false)
        {
            gameObject.GetComponent<RectTransform>().transform.Translate(new Vector3(0f, -25f, 0f));
        }
        
    }
}
