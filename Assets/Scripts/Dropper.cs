using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mr;
    Rigidbody rb;
    public float dropTimer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();

        rb.useGravity = false;
        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTimer)
        {
            //Debug.Log("Drop time elapsed");
            //GetComponent<Rigidbody>().useGravity = true;
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
