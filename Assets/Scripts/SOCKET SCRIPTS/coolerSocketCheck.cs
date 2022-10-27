using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coolerSocketCheck : MonoBehaviour
{


    public bool variabila_COOLER = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void coolerIN()
    {
       variabila_COOLER = true;
        Debug.Log(variabila_COOLER);
    }

    public void coolerOUT()
    {
       variabila_COOLER = false;
        Debug.Log(variabila_COOLER); 
    }
}