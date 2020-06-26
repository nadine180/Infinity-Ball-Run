using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text uiTimer;
    private float mainTimer = 60f;
    public float timer;
    public GameObject Sonic;
    public bool ironball = false;
    // Update is called once per frame

    void Start(){
        timer = mainTimer;
    }
    void Update()
    {
      //  if(timer >= 0.0f && canCount)
        //{
    if(timer >= 0.0f)
    {
        timer -=  Time.deltaTime;   
        if(ironball){
            ironball = false;
            timer -=10f;
        }     
        //Debug.Log("TIME " + timer);
        uiTimer.text = ((int)timer).ToString("D"); 
    }
    else
    {

        Debug.Log("IN TIMER");
        FindObjectOfType<gamePlay>().EndGame();
    }       
        //}
       
    }

   
     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("In collision");
    }

    public void hitIronBall (){
        
    }
    
    
}

