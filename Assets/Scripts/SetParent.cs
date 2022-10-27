using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent : MonoBehaviour
{

    public GameObject monitor;
    public GameObject ecranPornit;
    // Start is called before the first frame update
    void Start()
    {
        monitor.transform.parent = ecranPornit.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
