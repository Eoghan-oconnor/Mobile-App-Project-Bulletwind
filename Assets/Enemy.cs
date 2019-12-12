using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Bullet bullet;

     void OnCollisionEnter2D(Collision2D c){
        
        if(bullet){
            Destroy(gameObject);
        }

    }
}
