using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherboardSocketCheck : MonoBehaviour
{


    public bool variabila_MOTHERBOARD = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void motherboardIN()
    {
       variabila_MOTHERBOARD = true;
        Debug.Log(variabila_MOTHERBOARD);
    }

    public void motherboardOUT()
    {
       variabila_MOTHERBOARD = false;
        Debug.Log(variabila_MOTHERBOARD); 
    }
}