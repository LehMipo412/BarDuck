using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMoshe : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mosheRigidBody2d;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        mosheRigidBody2d.AddForce(Vector2.right * (Time.deltaTime * speed));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
