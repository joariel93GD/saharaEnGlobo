using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float runSpeed;
    private float moveInput;


    private Rigidbody2D myBody;






    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

        
    }

    
    void FixedUpdate()
    {
        Movement();
    }

    void Movement ()
    {
        moveInput = Input.GetAxisRaw("Horizontal")*runSpeed;
        myBody.velocity = new Vector2(moveInput, myBody.velocity.y);
    }

}
