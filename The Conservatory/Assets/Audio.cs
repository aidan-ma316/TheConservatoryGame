using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    


    public Slider slide;

    private void Update()
    {
        Adjust();
    }

    private void Start()
    {
        slide.value = AudioListener.volume;
    }

    void Adjust() { AudioListener.volume = slide.value; }
}
