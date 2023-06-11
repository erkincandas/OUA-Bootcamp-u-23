using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
   public void PlayButton()
    {
        SceneManager.LoadScene("ClassLevel");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
