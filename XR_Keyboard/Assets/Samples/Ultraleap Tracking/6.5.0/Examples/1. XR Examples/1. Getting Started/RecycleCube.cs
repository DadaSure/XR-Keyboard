using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleCube : MonoBehaviour
{
    public float lowestHeight = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < lowestHeight)
        {
            Destroy(gameObject);
        }
    }
}
