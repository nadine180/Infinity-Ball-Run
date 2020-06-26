using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_movement : MonoBehaviour
{


   public Camera mainCamera;
   public Camera secondaryCamera;
   private float speed = 1f;  
   public Rigidbody rb;
   public GameObject ground;
   private bool pause = false;
   public Text scoreText;
   public Text timerText;
   Timer timerScript;
   private bool onGround;
   public bool Invincible;

    // Start is called before the first frame update
    void Start()
    {
        secondaryCamera.enabled = false;
        mainCamera.enabled = true;
        onGround = true;
        
    }

    // Update is called once per frame
    void Update()
    {

      if(!Invincible)
        speed = 10f;

      else
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
            Debug.Log("In secondary camera");
            mainCamera.enabled = !mainCamera.enabled;
            secondaryCamera.enabled = !secondaryCamera.enabled;
        }


    }

    //update for the physics components

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
    if(!Invincible){

        if(collider.gameObject.tag == "Iron Ball")
        {
            Debug.Log("In iron ball");
            //timerText.text = (int.Parse(timerText.text)-10).ToString("D");
            (FindObjectOfType<Timer>()).ironball = true;
            //Destroy(collider.gameObject);
            collider.gameObject.SetActive(false);
            FindObjectOfType<SFX>().obstaclePlay();
        }

        if(collider.gameObject.tag == "Coin"){

           collider.gameObject.SetActive(false);
            FindObjectOfType<SFX>().collectiblePlay();
                   }

        if(collider.gameObject.tag == "Collectible")
        {

           FindObjectOfType<SFX>().collectiblePlay();
           collider.gameObject.SetActive(false);
           FindObjectOfType<sliderControl>().increaseSlider();
          
        }

        if(collider.gameObject.tag == "Bomb"){
            FindObjectOfType<gamePlay>().EndGame();
        }

    }    
    }
}
