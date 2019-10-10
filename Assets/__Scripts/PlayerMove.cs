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
    private bool direction = true;
    private Rigidbody2D rb;

    // == Private Methods ==
    // Update is called once per frame

     void Start()
     {
         rb = GetComponent<Rigidbody2D>();
     }
    void Update()
    {
        Move();
        
    }
    

    private void Move()
    {
       
            // convert user input into world movement
            float horizontalMovement = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
            float verticalMovement = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        
            Vector2 movement = new Vector2(horizontalMovement,verticalMovement);
            rb.velocity = movement.normalized * moveSpeed;

            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
             transform.rotation = Quaternion.Euler(0,0,90);
            
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.rotation = Quaternion.Euler(0,0, 270);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)){
                transform.rotation = Quaternion.Euler(0,0,180);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow)) 
            {
                transform.rotation = Quaternion.Euler(0,0,0);
            }


    }

    
   
}
