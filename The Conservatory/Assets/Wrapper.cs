using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wrapper : MonoBehaviour
{
    public AssetBundle a;
    void Start()
    {
        
    }

    //public void loadTutorial() { SceneManager.LoadScene(); }

    public void loadGame() { SceneManager.LoadScene("SCENE"); }


    public void loadMenu() { SceneManager.LoadScene("Menu"); }

    public void loadSettings() { SceneManager.LoadScene("Settings"); }
    public void loadSettings2() { SceneManager.LoadScene("Settings2"); }

    public void loadCredits() { SceneManager.LoadScene("Credits"); }

    public void exitGame() { Application.Quit(); }


    //public void loadSettings() { SceneManager.LoadScene(Settings.name); }
    // public void loadCredits() { SceneManager.LoadScene(Credits.name); }
}
