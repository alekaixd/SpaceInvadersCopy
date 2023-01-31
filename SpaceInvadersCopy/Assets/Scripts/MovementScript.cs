using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float speed = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        if (transform.position.x > 9)
        {
            transform.position = new Vector2(9, transform.position.y);
        }
        if (transform.position.x < -9)
        {
            transform.position = new Vector2(-9, transform.position.y);
        }
    }
}
