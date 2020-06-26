using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControl : MonoBehaviour
{
    player_movement movement;
    public InvinciblePlayer ip;
    public Slider slider;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 50;
        slider.wholeNumbers = true;
        slider.value = 0;
        movement =FindObjectOfType<player_movement>();
        ip = FindObjectOfType<InvinciblePlayer>();
        timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
      
       if(movement.Invincible)
       {

            
           timer -= Time.deltaTime;

           if(timer <= 0)
           {
              movement.Invincible = false; 
              timer = 5f;
           }
       }
    }

    public void increaseSlider()
    {
        slider.value += 10;
         if(slider.value == 50)
        {
            movement.Invincible = true;
            FindObjectOfType<SFX>().invinciblePlay();
            slider.value = 0;
        }
    }

    
}
