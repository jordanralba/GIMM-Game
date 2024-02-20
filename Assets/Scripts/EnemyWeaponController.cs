using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponController : MonoBehaviour
{
    private GameObject player;
    public float speed;

    public GameObject projectile;
    public GameObject canvas;
    public float spawnDelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        InvokeRepeating("EnemyFire", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemyFire()
    {
        if(canvas.activeInHierarchy){
            Rigidbody projectileRb;
            projectileRb = Instantiate(projectile, transform.position, transform.rotation).GetComponent<Rigidbody>();
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            projectileRb.AddForce(lookDirection * speed, ForceMode.VelocityChange);
        }
    }
}
