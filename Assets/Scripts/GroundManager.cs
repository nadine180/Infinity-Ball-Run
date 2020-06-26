using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    public GameObject ground;
    public GameObject[] gameItems;
    private Transform playerTransform;

    private float generateZ = 0.0f;
    private float groundLength = 10.0f;
    private int screenGrounds = 10;
    private List<GameObject> activeGrounds;
    private float safeZone = 20.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        activeGrounds = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Sonic").transform;
        for(int i = 0; i < screenGrounds;i++){
            expandGround();
        }
    
    }

    // Update is called once per frame 
    void Update()
    {
        if(playerTransform.position.z -safeZone> (generateZ - screenGrounds*groundLength))
        {
            deleteGround();
            expandGround();
            
        }
    }

    private void expandGround (int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(ground) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * generateZ;
        generateZ += groundLength;
        
        List<float> laneIndex = new List<float>();
        laneIndex.Add(-3.25f);
        laneIndex.Add(0.0f);
        laneIndex.Add(3.25f);


         int numGameItems = Random.Range(1,4);  //The number of game items in a row
         int l = 3;
         List <int> usedLanes = new List<int>();
        for(int i = 0; i < numGameItems;i++)
        {
            int lane = Random.Range(0,l);

             int item = Random.Range(0,4);
            //GameObject gameItem = Instantiate(gameItems[item]) as GameObject;
 
             GameObject gameItem =Instantiate(gameItems[item]) as GameObject;
             gameItem.SetActive(true);
             gameItem.transform.position = new Vector3(laneIndex[lane],0.7f,generateZ);
             gameItem.transform.SetParent(go.transform);

             laneIndex.RemoveAt(lane);
             l -= 1;
                 
            
        }

        activeGrounds.Add(go);


    }
    private void deleteGround()
    {
    //    if(sonic.trasform.position.z<groundLength)
        Debug.Log("In delete grounds");
        Destroy(activeGrounds[0]);
        activeGrounds.RemoveAt(0);
    }

    
}
