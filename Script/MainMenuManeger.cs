using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManeger : MonoBehaviour {

    public GameObject Panel;
    


    public void GamePlay()

    {
        SceneManager.LoadScene ("Game_Scena");
    }
   
    public void Settings()
    {

    }

  
    public void About()
    {

        Panel.SetActive(true);
    }
}
