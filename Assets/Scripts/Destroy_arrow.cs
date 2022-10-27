using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_arrow : MonoBehaviour
{
    public GameObject arrow;

    public void destroy_arrow()
    {
        Destroy(arrow);
    }
}
