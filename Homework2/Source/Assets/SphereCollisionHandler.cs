using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class SphereCollisionHandler : MonoBehaviour
{
    public TMP_Text worldText;
    private Vector3 _initialPosition; // Store the initial position of the sphere

    void Start()
    {
        // Initialize the initial position when the game starts
        _initialPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered collision with " + collision.gameObject.name);
        if (collision.gameObject.name == "Plane")
        {
            float distance = Vector3.Distance(_initialPosition, transform.position);
            distance *= 1000;
            int score = (int)Math.Round(distance, 0);
            worldText.text = "Score: " + score.ToString("F2");
        }
       
    }

  
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colliding with " + collision.gameObject.name);
    }


    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited collision with " + collision.gameObject.name);
    }
}