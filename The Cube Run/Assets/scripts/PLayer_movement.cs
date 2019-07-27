﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;

    void FixedUpdate(){

        rb.AddForce(0,0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysforce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange );
        }
        
        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange );
        }
        
        if (rb.position.y < -1f){
            FindObjectOfType<Manager>().Game_Over();
        }
        

    }

}
