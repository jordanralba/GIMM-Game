using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    AudioSource audioSource;
    private float scaleMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        scaleMagnitude = transform.localScale.x * transform.localScale.y * transform.localScale.z;
        audioSource.pitch = (5f + scaleMagnitude)/scaleMagnitude;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision){
        Debug.Log(collision);
        if(collision.gameObject.CompareTag("Player")){
            audioSource.Play();
        }
    }

}
