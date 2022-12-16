using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public  float waitTime = 5f;
    public int damage = 10;

    public IEnumerator deleteTimer()
    {
        Debug.Log("Pellets are being deleted!");
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }


    private void Start()
    {
        rb.velocity = transform.right * speed;
        StartCoroutine(deleteTimer());
    }

    private void OnTriggerEnter2D(Collider2D HitInfo)
    {
        EnemyHealth enemy = HitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
     
        
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.X))
        //{
         //   StartCoroutine(deleteTimer());
        //}
    }

}