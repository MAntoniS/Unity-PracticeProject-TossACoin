using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    

    // Update is called once per frame
    void Update()
    {
        MakeAJump();
        
    }

    public void MakeAJump() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacja");
            rigidbody.velocity = Vector2.up * 15f;
        }
    }
}
