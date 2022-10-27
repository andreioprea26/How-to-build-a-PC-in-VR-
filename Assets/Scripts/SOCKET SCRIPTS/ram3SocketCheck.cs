using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ram3SocketCheck : MonoBehaviour
{


    public bool variabila_RAM3 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ram3IN()
    {
       variabila_RAM3 = true;
        Debug.Log(variabila_RAM3);
    }

    public void ram3OUT()
    {
       variabila_RAM3 = false;
        Debug.Log(variabila_RAM3); 
    }
}