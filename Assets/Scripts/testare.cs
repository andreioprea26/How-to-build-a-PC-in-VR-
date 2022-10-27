using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testare : MonoBehaviour
{

    //public GameObject fan;
    //Vector3 jon; 
    bool verificare=false;
    float speed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(verificare)
        {
        transform.Rotate(0f, 0f,90.0f * Time.deltaTime * speed);
        
        }
    }

    public void rotire()
    {
        verificare = true;
    }
}
