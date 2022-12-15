using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    private float shootingTime;

    public Transform position;

    public Transform weaponMuzzle; //The empty game object which will be our weapon muzzle to shoot from
    public GameObject bullet1;
    public GameObject bullet2;
    private GameObject bullet;

    [SerializeField] private float fireRate = 3000f; //Fire every 3 seconds
    [SerializeField] private float shootingPower = 20f; //force of projection

    private void Start()
    {
        bullet = bullet1;
    }

    void Update()
    {
       /* Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);
       */
        if (Input.GetMouseButton(0))
        {
            Fire(position);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            bullet = bullet1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            bullet = bullet2;
        }
    }

    private void Fire(Transform target)
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000; //set the local var. to current time of shooting
            Vector2 myPos = new Vector2(weaponMuzzle.position.x, weaponMuzzle.position.y); //our curr position is where our muzzle points
            GameObject projectile = Instantiate(bullet, myPos, Quaternion.identity); //create our bullet
            Vector2 direction = myPos - (Vector2)target.position; //get the direction to the target
            projectile.GetComponent<Rigidbody2D>().velocity = -direction * shootingPower; //shoot the bullet
        }
    }
}
