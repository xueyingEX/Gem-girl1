using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float speed = 1.0f; 
    private Vector2 lastInput;
    private Vector2 currentInput;
    private Vector2 targetPosition;
    private Animator animator; 

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        GetInput();
        Move();
        UpdateAnimation();
    }

    private void GetInput()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (moveInput != Vector2.zero)
        {
            lastInput = moveInput;
        }
    }

    private void Move()
    {
        if ((Vector2)transform.position == targetPosition)
        {
            if (IsWalkable(targetPosition + lastInput))
            {
                targetPosition += lastInput;
                currentInput = lastInput;
            }
            else if (IsWalkable(targetPosition + currentInput))
            {
                targetPosition += currentInput;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private void UpdateAnimation()
    {
        animator.SetBool("MoveUp", currentInput == Vector2.up);
        animator.SetBool("MoveDown", currentInput == Vector2.down);
        animator.SetBool("MoveLeft", currentInput == Vector2.left);
        animator.SetBool("MoveRight", currentInput == Vector2.right);
    }

    private bool IsWalkable(Vector2 direction)
    {
        return true; 
    }

    private ParticleSystem particleEffect;
    private void Start()
    {
        particleEffect = GetComponentInChildren<ParticleSystem>();
    }

    public void StartParticleEffect()
    {
        particleEffect.Play();
    }

    public void StopParticleEffect()
    {
        particleEffect.Stop();
    }

}