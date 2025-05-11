using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    
    public GameObject destroyOutside;

    void Start()
    {
        if (transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }
}
