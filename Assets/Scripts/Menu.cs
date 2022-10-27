using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void Easy () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }

    public void Hard () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2 );
    }
    
}
