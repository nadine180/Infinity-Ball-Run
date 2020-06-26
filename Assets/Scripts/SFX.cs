using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{

    public AudioSource csfx;
    public AudioSource osfx;
    public AudioSource isfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void collectiblePlay()
    {
        csfx.Play();
    }

     public void obstaclePlay()
    {
        osfx.Play();
    }

    public void invinciblePlay()
    {
        isfx.Play();
    }
}
