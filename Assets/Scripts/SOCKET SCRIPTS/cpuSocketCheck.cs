using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpuSocketCheck : MonoBehaviour
{


    public bool variabila_CPU = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cpuIN()
    {
       variabila_CPU = true;
        Debug.Log(variabila_CPU);
    }

    public void cpuOUT()
    {
       variabila_CPU = false;
        Debug.Log(variabila_CPU); 
    }
}