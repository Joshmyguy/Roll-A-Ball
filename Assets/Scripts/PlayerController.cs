using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody rb;
    public float speed = 1.0f;


    void Start()
    {
        //rigidbody component attached to the game object
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        //Input controls to make the player move
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //New vector 3 for the movement
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Applying speed with the players movement
        rb.AddForce(movement * speed);
    }
}
