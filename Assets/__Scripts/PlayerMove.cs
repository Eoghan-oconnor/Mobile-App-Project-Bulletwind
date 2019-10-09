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
    private float _rotation;
    private float CharacterPosition = 1f;

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

            if(Input.GetKeyDown(KeyCode.LeftArrow) && CharacterPosition != 2f)
            {
             transform.Rotate(0,0,90);
             CharacterPosition = 2f;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && CharacterPosition != 3f)
            {
                transform.Rotate(0,0, 270);
                CharacterPosition = 3f;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && CharacterPosition != 4f){
                transform.Rotate(0,0,180);
                CharacterPosition = 4f;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && CharacterPosition != 5f) 
            {
                transform.Rotate(0,0,360);
                CharacterPosition = 5f;
            }


    }

    
   
}
