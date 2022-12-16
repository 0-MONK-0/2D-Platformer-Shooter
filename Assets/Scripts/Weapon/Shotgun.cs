using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public Transform firePoint5;
    public Transform firePoint6;
    public Transform firePoint7;

    public GameObject Pellet;


    void Update()
    {
       if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Shooting Code

        Instantiate(Pellet, firePoint1.position, firePoint1.rotation);
        Instantiate(Pellet, firePoint2.position, firePoint2.rotation);
        Instantiate(Pellet, firePoint3.position, firePoint3.rotation);
        Instantiate(Pellet, firePoint4.position, firePoint4.rotation);
        Instantiate(Pellet, firePoint5.position, firePoint5.rotation);
        Instantiate(Pellet, firePoint6.position, firePoint6.rotation);
        Instantiate(Pellet, firePoint7.position, firePoint7.rotation);
    }

    
}
