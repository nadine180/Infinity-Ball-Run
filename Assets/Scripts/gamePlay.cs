using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlay : MonoBehaviour
{

    bool gameHasEnded = false;

    public void EndGame()
    {

        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
