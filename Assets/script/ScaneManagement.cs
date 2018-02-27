using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaneManagement : MonoBehaviour {

    public void KembaliMainMenu() {
        Application.LoadLevel("MainMenu");
    }

    public void InfoKuis(){
        Application.LoadLevel("InfoKuis");
    }
    public void KuisLevel()
    {
        Application.LoadLevel("KuisLevel");
    }
    public void Mudah1()
    {
        Application.LoadLevel("Mudah1");
    }
    public void Sedang1()
    {
        Application.LoadLevel("Sedang1");
    }
    public void Sulit1()
    {
        Application.LoadLevel("Sulit1");
    }

    public void Close() {
        Application.Quit();
    }
}
