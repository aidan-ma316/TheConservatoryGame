using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseOver2 : MonoBehaviour
{
    private bool ismouse = false;
    
 

    private void Update()
    {
        if (ismouse == true)
        {
            gameObject.GetComponent<RectTransform>().transform.Translate(new Vector3(0f, 0f, 0f));
        }
    }

    public void up()
    {
        gameObject.GetComponent<RectTransform>().transform.Translate(new Vector3(25f, 0f, 0f));
        gameObject.GetComponent<CanvasGroup>().alpha = 1f;
    }

    public void down()
    {
        gameObject.GetComponent<RectTransform>().transform.Translate(new Vector3(-25f, 0f, 0f));
        gameObject.GetComponent<CanvasGroup>().alpha = .2f;
    }
}
