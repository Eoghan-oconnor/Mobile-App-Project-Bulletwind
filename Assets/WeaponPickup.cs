using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject[] weapons;
    public GameObject weaponHere;



    void Start()
    {
        //weaponHere = weapons[1];
        GetComponent<SpriteRenderer>().sprite = weaponHere.GetComponent<SpriteRenderer>().sprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D WhatHitMe){

        var player = WhatHitMe.GetComponent<PlayerMove>();
        if(player){
            Destroy(gameObject);
        }
    }

     
}
