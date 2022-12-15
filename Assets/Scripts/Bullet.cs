using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Life timer")]
    [SerializeField] private float aliveTimer = 1;
    private void Update()
    {
        StartCoroutine(destroyTimer());
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col && !col.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator destroyTimer()
    {
        yield return new WaitForSeconds(aliveTimer);
        Destroy(gameObject);
    }
}