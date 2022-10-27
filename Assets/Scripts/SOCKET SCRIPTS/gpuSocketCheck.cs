using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpuSocketCheck : MonoBehaviour
{


    public bool variabila_GPU = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gpuIN()
    {
        variabila_GPU = true;
        Debug.Log(variabila_GPU);
    }

    public void gpuOUT()
    {
        variabila_GPU = false;
        Debug.Log(variabila_GPU); 
    }
}
