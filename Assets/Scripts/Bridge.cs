using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public int turnSpeed = 5;
    public Transform obectToOrbit;
    // Start is called before the first frame update
    public bool putdown = true;
    public bool turning = true;
    void Start()
    {

    }

    // Update is called once per frame
    
    public void LateUpdate()
    {
        if (turning)
        {
            transform.RotateAround(obectToOrbit.position, Vector3.forward, (putdown ? -turnSpeed : turnSpeed) * Time.deltaTime);
            if(putdown && transform.rotation.z < -0.73f || !putdown && transform.rotation.z > 0.01f)
            {
                turning = false;
            }
        }
       
    }
}

