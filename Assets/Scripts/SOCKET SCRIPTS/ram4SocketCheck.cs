using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ram4SocketCheck : MonoBehaviour
{


    public bool variabila_RAM4 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ram4IN()
    {
       variabila_RAM4 = true;
        Debug.Log(variabila_RAM4);
    }

    public void ram4OUT()
    {
       variabila_RAM4 = false;
        Debug.Log(variabila_RAM4); 
    }
}