using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for first person camera remove the vector3 stuff


public class followPlayer : MonoBehaviour
{
 //vector3 stores three floats
    public Transform sonic;
   public Vector3 offset = new Vector3(0,-3,-7);

    // Update is called once per frame
    void Update()
    {
        
       transform.position = sonic.position + offset;
        
    }
}
 