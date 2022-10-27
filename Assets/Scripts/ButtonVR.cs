using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;

    public GameObject monitor;
    public GameObject ecranPornit; 


    GameObject gpuSocket;
    bool testGPU;

    GameObject cpuSocket;
    bool testCPU; 

    GameObject coolerSocket;
    bool testCOOLER; 

    GameObject ssdSocket;
    bool testSSD; 

    GameObject ram1Socket;
    bool testRAM1; 

    GameObject ram2Socket;
    bool testRAM2; 

    GameObject ram3Socket;
    bool testRAM3; 

    GameObject ram4Socket;
    bool testRAM4; 
    
    GameObject motherboardSocket;
    bool testMOTHERBOARD; 

    GameObject sursaSocket;
    bool testSURSA; 

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(-0.01f, 0, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true ; 
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0, 0 );
            onRelease.Invoke();
            isPressed = false;
            
        }
    }
    
    public void SpawnObject()
    {

        gpuSocket = GameObject.Find("GPU socket");
        testGPU = gpuSocket.GetComponent<gpuSocketCheck>().variabila_GPU;
        
        cpuSocket = GameObject.Find("CPU socket");
        testCPU = cpuSocket.GetComponent<cpuSocketCheck>().variabila_CPU;

        coolerSocket = GameObject.Find("COOLER socket");
        testCOOLER = coolerSocket.GetComponent<coolerSocketCheck>().variabila_COOLER;

        ssdSocket = GameObject.Find("SSD socket");
        testSSD = ssdSocket.GetComponent<ssdSocketCheck>().variabila_SSD;

        ram1Socket = GameObject.Find("RAM socket 1");
        testRAM1 = ram1Socket.GetComponent<ram1SocketCheck>().variabila_RAM1;

        ram2Socket = GameObject.Find("RAM socket 2");
        testRAM2 = ram2Socket.GetComponent<ram2SocketCheck>().variabila_RAM2;

        ram3Socket = GameObject.Find("RAM socket 3");
        testRAM3 = ram3Socket.GetComponent<ram3SocketCheck>().variabila_RAM3;

        ram4Socket = GameObject.Find("RAM socket 4");
        testRAM4 = ram4Socket.GetComponent<ram4SocketCheck>().variabila_RAM4;

        motherboardSocket = GameObject.Find("MOTHERBOARD socket");
        testMOTHERBOARD = motherboardSocket.GetComponent<motherboardSocketCheck>().variabila_MOTHERBOARD;

        sursaSocket = GameObject.Find("SURSA socket");
        testSURSA = sursaSocket.GetComponent<sursaSocketCheck>().variabila_SURSA;

        if(testGPU && testCPU && testCOOLER && testSSD && testRAM1 && testRAM1 && testRAM3 && testRAM4 && testMOTHERBOARD && testSURSA )
        {   
            
            GameObject go = Instantiate(ecranPornit, new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
            go.transform.parent = GameObject.Find("Monitor").transform;
            go.transform.localPosition = new Vector3(-0.005f,0.355f,-0.11f);
            go.transform.Rotate(-90.0f, 90f, 0.0f);
            go.transform.localScale = new Vector3(1,1,1);
            
            
        }    
    }
}
