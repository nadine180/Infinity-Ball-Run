using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondary_followPlayer : MonoBehaviour
{

      public Transform sonic;
      private Vector3 offset = new Vector3(0,0,0);
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sonic.position + offset;
    }
}
