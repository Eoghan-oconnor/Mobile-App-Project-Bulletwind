using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // == Public Properties ==
    
    // == Private Variables ==
    [SerializeField]
    private float moveSpeed = 10.0f;

    // == Private Methods ==
    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
    if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {
 
    // convert user input into world movement
    float horizontalMovement = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
    float verticalMovement = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
 
     //assign movement to a single vector3
     Vector3 directionOfMovement = new Vector3(horizontalMovement, verticalMovement, 0);
 
    // apply movement to player's transform
    gameObject.transform.Translate(directionOfMovement);
}
    }
   
}
