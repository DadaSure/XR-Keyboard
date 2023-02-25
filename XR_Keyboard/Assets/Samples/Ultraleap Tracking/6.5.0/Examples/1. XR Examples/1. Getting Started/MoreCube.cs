using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreCube : MonoBehaviour
{
    public GameObject cube_prefab;

    //public float x = 0;
    //public float y = 0;
    //public float z = 0;

    public bool generate = false;
    public float second = 1;
    private float time = 0;

    public GameObject holder;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (generate && time>second)
        {
            GameObject newCude = Instantiate(cube_prefab, transform.position, Quaternion.identity);
            newCude.transform.parent = holder.transform;
            time = 0;
        }
    }
}
