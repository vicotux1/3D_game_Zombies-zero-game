using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    private Rigidbody rb;
    [Range(0.0f, 5.0f)][SerializeField]float SpeedZ;
    // Start is called before the first frame update
    void Start(){
        rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity=Vector3.back*SpeedZ; 
    }
}
