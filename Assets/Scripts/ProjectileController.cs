using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    
    public float speed;
    private Rigidbody projectileRb;
    //private Rigidbody enemyRb;
    private GameObject player;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        projectileRb = GetComponent<Rigidbody>();
        //enemyRb = enemy.GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            Debug.Log("Game Over");
            Destroy(gameObject);
        }else if(collision.gameObject.CompareTag("Character")){
            Debug.Log("I've Been Hit!");
            Destroy(gameObject);
        }
        else if(collision.gameObject.CompareTag("Portal2D")){
            Debug.Log("Warped Projectile!");
            Destroy(gameObject);
        }else if(!collision.gameObject.CompareTag("Enemy2D")){
            Destroy(gameObject);
        }

        
        
    }
    
}
