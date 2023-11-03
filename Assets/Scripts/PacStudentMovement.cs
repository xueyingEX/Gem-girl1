using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Vector2 direction;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.zero; 
    }

    private void Update()
    {
        HandleInput();
        Move();
    }

    private void HandleInput()
    {
        Vector2 prevDirection = direction;

        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
            animator.SetInteger("Direction 0", 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;
            animator.SetInteger("Direction 2", 2);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
            animator.SetInteger("Direction 3", 3);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
            animator.SetInteger("Direction 1", 1);
        }

        
        if(prevDirection != direction)
        {
            transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), Mathf.Round(transform.position.z));
        }
    }

    private void Move()
    {
        transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;
    }
}
