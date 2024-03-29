﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Camera camera;
    Vector2 mousePos;
    

   
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);


    }

     void FixedUpdate()
     {

         rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

         Vector2 lookDir = mousePos - rb.position;
         float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
         rb.rotation = angle;

         
     }

    

    
   
}
