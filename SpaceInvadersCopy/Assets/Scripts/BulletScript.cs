using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float bulletSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BulletLifetime());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("Kill!");
    }

    private IEnumerator BulletLifetime()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
