using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMult = 1f;
    bool isGrounded;
    public float maxSpeed;    
    private Rigidbody playerRb;
    AudioSource audioSource;
  
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Vertical");
        float zInput = Input.GetAxis("Horizontal");
        
        if (Input.GetAxis("Vertical") != 0)
        {
            if(!audioSource.isPlaying){
                audioSource.pitch = Random.Range(2.0f, 3.0f);
                audioSource.volume = Random.Range(0.2f, .3f);
                audioSource.Play(); 
            }
            if(playerRb.velocity.magnitude < maxSpeed){
                playerRb.AddRelativeForce(Vector3.forward * xInput * speedMult, ForceMode.Acceleration);
                //playerRb.velocity += transform.forward * xInput * speedMult;
                Debug.Log(playerRb.velocity); 
            }
            
        }else if (Input.GetAxis("Horizontal") != 0)
        {
            if(!audioSource.isPlaying){
                audioSource.pitch = Random.Range(2.0f, 3.0f);
                audioSource.volume = Random.Range(0.2f, .3f);
                audioSource.Play(); 
            }
            if(playerRb.velocity.magnitude < maxSpeed){
                playerRb.AddRelativeForce(Vector3.right * zInput * speedMult, ForceMode.Acceleration);
                Debug.Log(playerRb.velocity); 
            }
            
        }else{
            audioSource.Stop();
        }
               
        
    }
}
