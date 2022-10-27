using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sursaSocketCheck : MonoBehaviour
{


    public bool variabila_SURSA = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sursaIN()
    {
       variabila_SURSA = true;
        Debug.Log(variabila_SURSA);
    }

    public void sursaOUT()
    {
       variabila_SURSA = false;
        Debug.Log(variabila_SURSA); 
    }
}