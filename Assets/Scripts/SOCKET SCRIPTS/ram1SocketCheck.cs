using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ram1SocketCheck : MonoBehaviour
{


    public bool variabila_RAM1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ram1IN()
    {
       variabila_RAM1 = true;
        Debug.Log(variabila_RAM1);
    }

    public void ram1OUT()
    {
       variabila_RAM1 = false;
        Debug.Log(variabila_RAM1); 
    }
}