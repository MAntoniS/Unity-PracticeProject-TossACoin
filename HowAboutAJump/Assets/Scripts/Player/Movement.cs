using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0, .3f)]
    [SerializeField]
    private float m_MovementSmoothing = .05f;	// How much to smooth out the movement
    public new Rigidbody2D rb;
    [Range(1,10)]
    public float moveX;
    public float jumpForce =  15f;
    public bool jump = false;
    private Vector3 m_Velocity = Vector3.zero;
 


    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
            { jump = true; }
    }

    private void FixedUpdate()
    {
        Movemen(moveX,jump);
        jump = false;
    }

    private void Movemen(float mov, bool jump)
    {
        Vector3 targetVelocity = new Vector2(mov * 10f, rb.velocity.y);
        // And then smoothing it out and applying it to the character
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        if (jump)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            Debug.Log("Dlaczego nie dziala???");
        }
    }


    
   
 
    }
