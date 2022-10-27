using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class details_SURSA : MonoBehaviour
{   

    public GameObject obj_to_spawn ; 
    public GameObject spawn_to_delete;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        GameObject go = Instantiate(obj_to_spawn, new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
        go.transform.parent = GameObject.Find("SURSA").transform;
        go.transform.localPosition = new Vector3(0f,0.386f,0f);
        
    }

    public void DestroyScriptInstance()
    {
        // Removes this script instance from the game object
        spawn_to_delete = GameObject.Find("detail_sursa(Clone)");
        Destroy(spawn_to_delete);
    }
}
