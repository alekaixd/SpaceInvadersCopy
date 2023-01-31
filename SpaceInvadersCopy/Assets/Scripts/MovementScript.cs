using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float speed = 14.0f;
    [SerializeField] private GameObject bulletPrefab;
    private bool isBulletSpawnable = true;
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
        if (Input.GetButton("Jump"))
        {
            speed = 10.0f;
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
