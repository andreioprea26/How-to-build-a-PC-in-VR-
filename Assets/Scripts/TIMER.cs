using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;
using UnityEngine.UI;
using TMPro;

public class TIMER : MonoBehaviour
{
    public GameObject buttonTimer;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    
    
    public float timeStart;
    public TextMeshProUGUI textBox;

    bool verificare = false;
    
    
    

    void Start()
    {
        textBox.text = timeStart.ToString("F1");
    }

    void Update()
    {
        if(verificare)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F1");
        }
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed )
        {
            buttonTimer.transform .localPosition = new Vector3(0f, -0.01f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true ;  
            verificare=!verificare;
            
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if( other.gameObject == presser)
        {
            buttonTimer.transform.localPosition = new Vector3(0, 0, 0 );
            onRelease.Invoke();
            isPressed = false;
            
        }
    }
}