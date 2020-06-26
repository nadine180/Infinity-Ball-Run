using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

    public AudioSource pauseOST;
    // Start is called before the first frame update
    void Start()
    {
        pauseOST.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
