using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    
    public GameObject pauseScreen;
    public AudioSource pauseOST;
    // Update is called once per frame

    void Start()
    {
        pauseScreen.SetActive(false);
    }
    void Update()
    {
         if(Input.GetKeyDown("escape"))
        {
            if(isPaused)
            {
                Resume();
                
            }
            else
            {
               Pause();
              
            }
        }
    }

    public void Resume()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        pauseOST.Stop();
    }

    void Pause()
    {

        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
         pauseOST.Play();
    }

    public void Restart()
    {

       FindObjectOfType<gamePlay>().Restart();
    }
}
