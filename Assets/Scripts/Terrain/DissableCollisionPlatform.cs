using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableCollisionPlatform : MonoBehaviour
{
    [SerializeField] private BoxCollider2D PlatformCollider;
    public float waitTime;
    public float ResetPlatformTime;
    private bool Offset;

    public IEnumerator ResetTimerPlatform()
    {
        PlatformCollider.enabled = false;
        yield return new WaitForSeconds(ResetPlatformTime);
        PlatformCollider.enabled = true;

    }
    // Start is called before the first frame update
    void Start()
    {
        PlatformCollider = GetComponent<BoxCollider2D>();
        Offset = false;
        PlatformCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    { 

        if(Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(ResetTimerPlatform()); 
        }
    }
}
