using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updataewave : MonoBehaviour
{
    public SpawnEnemy se;
    public TextMeshProUGUI tmp;

    private void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }


    private void Update()
    {
        tmp.SetText("Wave:" + se.wave);
    }




}
