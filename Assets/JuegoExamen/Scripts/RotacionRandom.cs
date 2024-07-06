using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionRandom : MonoBehaviour
{
    public float tumble;
    
    private Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Start()
    {   
        rig.angularVelocity = Random.insideUnitSphere * tumble;
    }

}
