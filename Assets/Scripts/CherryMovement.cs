using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector2 direction;

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (IsOutOfScreen())
        {
            Destroy(gameObject);
        }
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir;
    }

    bool IsOutOfScreen()
    {
        Vector2 screenPosition = Camera.main.WorldToViewportPoint(transform.position);
        return screenPosition.y > 1.1f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PacStudent"))
        {
            Destroy(gameObject);
        }
    }
}

