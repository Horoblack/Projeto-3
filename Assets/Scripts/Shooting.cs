using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Status Arma")]
    public float bulletSpd;
    public float bulletRate;
    public float fireTickCd;
    public float fireTickNow;
   
    [Header("Objetos")]
    public Rigidbody bulletprefab;
    public GameObject playerr;
   
    void Shoot()
    {
        fireTickNow--;
        if (fireTickNow <= 0 && Input.GetButton("Fire1"))
        {        
                Rigidbody clone = Instantiate(bulletprefab, new Vector3(transform.position.x,1f, transform.position.z), transform.rotation );      
                clone.velocity = transform.forward * bulletSpd;
                fireTickNow = fireTickCd;
        }
    }
   

    private void FixedUpdate()
    {
        Shoot();
    }
}
