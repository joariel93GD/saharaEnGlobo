using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float runSpeed;
    private float moveInput;

    private Rigidbody2D myBody;
    private Animator animacion;

    private bool facingLeft;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
        
    }

    
    void FixedUpdate()
    {
        Movement();
    }
    /// <summary>
    /// Va a mover al personaje cuando se presionen las flechas, usa la velocidad que le asigne como runSpeed
    /// </summary>
    void Movement ()
    {
        moveInput = Input.GetAxisRaw("Horizontal")*runSpeed;
        myBody.velocity = new Vector2(moveInput, myBody.velocity.y);

        if (moveInput > 0)
            animacion.SetFloat("Speed", moveInput);
        else
            animacion.SetFloat("Speed", moveInput * -1);

        if (moveInput > 0 && !facingLeft || moveInput < 0 && facingLeft)
            Flip();
    }
    /// <summary>
    /// Va a voltear al personaje segun para donde este mirando
    /// </summary>
    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 transformScale = transform.localScale;
        transformScale.x *= -1;
        transform.localScale = transformScale;
    }

}
