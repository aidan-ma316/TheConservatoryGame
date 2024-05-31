using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintDamage : MonoBehaviour
{
    private TextMeshPro damageText;

    private void Awake()
    {
        damageText = transform.GetComponent<TextMeshPro>();
        StartCoroutine(waitDestroy());
    }

    public void change(float d)
    {
        damageText.SetText(Mathf.Round(d).ToString());
        damageText.fontSize += (d/100);
    }

    public void Update()
    {
        transform.Translate(new Vector3(transform.position.x, transform.position.y, 0f).normalized * .5f * Time.deltaTime, Space.World);
        if (transform.parent = null) { Destroy(gameObject); }
    }

    IEnumerator waitDestroy()
    {
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
