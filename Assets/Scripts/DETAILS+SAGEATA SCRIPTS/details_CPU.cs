using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class details_CPU : MonoBehaviour
{   

    public GameObject obj_to_spawn ; 
    public GameObject spawn_to_delete;

    GameObject cpuSocket;
    bool testCPU;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        GameObject go = Instantiate(obj_to_spawn, new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
        go.transform.parent = GameObject.Find("cpu").transform;
        go.transform.localPosition = new Vector3(0f,0.15f,0f);
        
    }

    public void DestroyScriptInstance()
    {

        cpuSocket = GameObject.Find("CPU socket");
        testCPU = cpuSocket.GetComponent<cpuSocketCheck>().variabila_CPU;

        // Removes this script instance from the game object
        spawn_to_delete = GameObject.Find("detail_CPU(Clone)");
        Destroy(spawn_to_delete);
    }
}
