using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallMovement : MonoBehaviour
{
    // The Rigidbody component attached to the ball
    private Rigidbody rb;



    // The boundary game object
    public GameObject boundary;

    [SerializeField] float forceStrength;
    float timeX;

    void Start()
    {
        // Get the Rigidbody component attached to the ball
        rb = GetComponent<Rigidbody>();

        timeX = 2f;
    }

    void Update()
    {
        
        if(timeX < 0)
        {
            // Apply a random force to the ball's Rigidbody
            rb.AddForce(Random.insideUnitSphere * forceStrength, ForceMode.Impulse);
        }
        else
        {
            timeX -= Time.deltaTime;
        }
    }
}
