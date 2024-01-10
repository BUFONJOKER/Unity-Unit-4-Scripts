using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody enemyRigidBody;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position-transform.position).normalized;
        enemyRigidBody.AddForce(lookDirection * speed);
        if(transform.position.y < -10){
            Destroy(gameObject);
        }
    }
}
