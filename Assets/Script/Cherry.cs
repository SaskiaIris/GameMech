using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            
        }
        if (hitInfo.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
