using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 4f;
    public LayerMask groundMask;

    public Vector3 velocity;
    bool isGrounded;
    public int variableTest = 0;
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance, groundMask);
        
        if (isGrounded)
        {
            velocity.y = 0f;
            variableTest -= 1;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        

        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            variableTest += 1;
        }
        Debug.Log(variableTest);
        controller.Move(velocity * Time.deltaTime);
    }
}