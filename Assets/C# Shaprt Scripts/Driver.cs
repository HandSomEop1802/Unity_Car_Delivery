using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float bumpSpeed = 15f;


    void OnTriggerEnter2D (Collider2D other){
        if (other.tag == "Boost")
        {
          moveSpeed = boostSpeed;
        }
    void OnCollisionEnter2D(Collision2D other) {
            moveSpeed = bumpSpeed;
        }   
    }
    
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed *Time.deltaTime;
        float MoveAmount = Input.GetAxis("Vertical") * moveSpeed *Time.deltaTime ;
        transform.Rotate(0,0, -steerAmount);
        transform.Translate(0, MoveAmount, 0);
    }
}
