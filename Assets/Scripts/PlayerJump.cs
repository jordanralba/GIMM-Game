using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
   
    public float jumpMult = 1f;  
    public float jumpHeight = 2.5f;  
    bool isGrounded;
    public LayerMask groundMask;
    private Rigidbody playerRb;
    private Collider groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        groundCheck = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, jumpHeight, groundMask);
        //Debug.DrawRay(transform.position, Vector3.down, Color.red, jumpHeight);
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {   
            Debug.Log("jumped");
            playerRb.AddRelativeForce(Vector3.up * jumpMult, ForceMode.VelocityChange);
        }       
    }
}
