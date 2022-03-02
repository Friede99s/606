using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoving : MonoBehaviour
{
    public float speed;
    private float z;
    private void Start()
    {
        Destroy(gameObject, 5);
        z = Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg + 135;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(speed, speed, 0) * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Direction" || collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
