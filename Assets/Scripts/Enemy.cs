using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody projectileRb;
    private Rigidbody enemyRb;
    private GameObject player;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        projectileRb = GetComponent<Rigidbody>();
        enemyRb = enemy.GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - enemy.transform.position).normalized;
        projectileRb.AddForce(lookDirection * speed);
    }
}
