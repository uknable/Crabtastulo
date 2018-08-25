using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlatformUp : MonoBehaviour {

    public float moveForce = 5f;
    public GameObject platform;
    public Transform destinationPoint;
    private bool moving = false;
   
    // Use this for initialization
    void Update () {
        if (moving)
        {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, destinationPoint.position, Time.deltaTime * moveForce);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            moving = true;

        }
    }

    void Rise()
    {
        
    }
}
