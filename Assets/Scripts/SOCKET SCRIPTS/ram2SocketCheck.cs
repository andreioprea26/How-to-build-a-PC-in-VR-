using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ram2SocketCheck : MonoBehaviour
{


    public bool variabila_RAM2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ram2IN()
    {
       variabila_RAM2 = true;
        Debug.Log(variabila_RAM2);
    }

    public void ram2OUT()
    {
       variabila_RAM2 = false;
        Debug.Log(variabila_RAM2); 
    }
}