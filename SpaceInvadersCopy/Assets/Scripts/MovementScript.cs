using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float speed = 12.0f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Rigidbody2D rb;
    private bool isBulletSpawnable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (horizontalInput, 0) * speed;
        if (transform.position.x > 9)
        {
            transform.position = new Vector2(9, transform.position.y);
        }
        if (transform.position.x < -9)
        {
            transform.position = new Vector2(-9, transform.position.y);
        }
        if (Input.GetButton("Jump"))
        {
            speed = 7.0f;
            if (isBulletSpawnable == true)
            {
                StartCoroutine(SpawnBullet(0.3f));
            }
        }
        else
        {
            speed = 14.0f;
        }
    }

    private IEnumerator SpawnBullet(float seconds)
    {
        isBulletSpawnable = false;
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(seconds);
        isBulletSpawnable = true;
        
    }

     
}
