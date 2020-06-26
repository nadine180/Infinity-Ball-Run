using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvinciblePlayer : MonoBehaviour
{

    public Text scoreText;
    private float speed;
    private float timer = 5f;
    public Transform Sonic;
    public Camera mainCamera;
    public Camera secondaryCamera;
    bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      if(timer > 0.0f)
      {
        timer -= Time.deltaTime;
        speed = 20f;
         float h = Input.GetAxis("Horizontal"); //value of horizontal tol el wa2t b zero madam im not clicking 3al button
        float j = Input.GetAxis("Jump"); 
        
        // GetComponent<Transform>(); //name of componennt  between <>
        //transform.Translate(h*speed,0f,v* speed);

        transform.Translate(10*h*Time.deltaTime, 10*j*Time.deltaTime,speed*Time.deltaTime );
        scoreText.text = "Score: " + (int) transform.position.z;
        
         //the interval for update

        if(Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondaryCamera.enabled = !secondaryCamera.enabled;
        }

        if(Input.GetKeyDown("escape"))
        {
            if(!pause)
            {
                Time.timeScale = 0;
                pause = true;
            }
            else
            {
                {
                    Time.timeScale = 1;
                    pause = false;
                }
            }
        }
      }
      else{
          this.enabled = false;

      }
    }
    
}
