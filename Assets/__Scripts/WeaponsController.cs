using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
    // Player will fire on space bar

    [SerializeField]
    private Bullet bulletPreFab;
    [SerializeField]
    private float bulletSpeed =  5f;
    [SerializeField]
    private float firingRate = 0.4f;
    private GameObject bulletParent;
    private WeaponPickup armed;

     


    // Start is called before the first frame update
    void Start()
    {

        

        bulletParent = GameObject.Find("BulletParent");
        if(!bulletParent){
            bulletParent = new GameObject("BulletParent");
        }
    }

   

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space)){
            InvokeRepeating("Shoot", 0f, firingRate);
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            CancelInvoke("Shoot");
        }     
    }

    private void Shoot(){

        //var armed = GetComponent<WeaponPickup>();

        //var player = GetComponent<PlayerMove>();

       
            Bullet bullet = Instantiate(bulletPreFab);
            bullet.transform.position = transform.position;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.up * bulletSpeed;
        
       
    }
}
