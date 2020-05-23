using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Reference to RigidBody component 
    public Rigidbody rb;  

    //Fixed update is used instead of Update because FixedUpdate is very suitable for physics like stuff
    //velocity and force
    void FixedUpdate()
    {
         rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
