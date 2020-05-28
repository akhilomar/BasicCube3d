﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Reference to RigidBody component 
    public Rigidbody rb;  
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    //Fixed update is used instead of Update because FixedUpdate is very suitable for physics like stuff
    //velocity and force
    void FixedUpdate()
    {
         rb.AddForce(0, 0, forwardForce * Time.deltaTime);
         if(Input.GetKey("d")){
             rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
         if(Input.GetKey("a")){
             rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
         if(rb.position.y < -1f){
             FindObjectOfType<GameManage>().EndGame();
         }
    }
}

