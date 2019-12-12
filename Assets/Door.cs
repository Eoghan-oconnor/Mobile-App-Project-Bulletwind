using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c){

        Destroy(gameObject);

    }
}
