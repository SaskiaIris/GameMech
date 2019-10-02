using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float movement = horizontal * speed;
        float jump = vertical * speed;
        
        transform.position = new Vector2(transform.position.x + movement, 0);
        transform.position = new Vector2(0, transform.position.y + jump);
    }
}
