using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TIMER_HARD : MonoBehaviour
{
    public GameObject buttonTimer;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    
    
    public float timeStart=30f;
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI textScene;

    bool verificare = false;
    public GameObject mana_stanga;
    public GameObject mana_dreapta; 
    
    

    void Start()
    {
        textBox.text = timeStart.ToString("F1");
    }

    void Update()
    {
        if(verificare && timeStart>0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = timeStart.ToString("F1");
        }
        else if( verificare && timeStart <= 0)
        {
            Destroy(mana_stanga);
            Destroy(mana_dreapta);
            textScene.text = "Scene restarting in";
            textScene.fontSize = 6;
            timeStart = 5;
            if(timeStart==5)
            {
                timeStart -=Time.deltaTime;
            }
            Invoke("RestartScene", 5);

        }
    }
    
    public void RestartScene()
    {
        SceneManager.LoadScene("Hard");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed )
        {
            buttonTimer.transform .localPosition = new Vector3(0f, -0.01f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true ;

            verificare = true;
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