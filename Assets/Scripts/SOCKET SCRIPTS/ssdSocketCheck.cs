using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ssdSocketCheck : MonoBehaviour
{


    public bool variabila_SSD = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ssdIN()
    {
       variabila_SSD = true;
        Debug.Log(variabila_SSD);
    }

    public void ssdOUT()
    {
       variabila_SSD = false;
        Debug.Log(variabila_SSD); 
    }
}