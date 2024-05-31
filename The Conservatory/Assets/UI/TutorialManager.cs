using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] UI;
    public int current;

    private void Update()
    {
        if (current >= UI.Length) { Destroy(gameObject); }
    }

    private void Start()
    {
        current = 0;
        UI[current].SetActive(true);
    }

    public void showUI()
    {
        UI[current].SetActive(false);
        UI[current + 1].SetActive(true);
        current += 1;
    }

    public void Demolish()
    {
        Destroy(gameObject);
    }
}
