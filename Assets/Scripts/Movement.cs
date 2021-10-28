using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    [SerializeField]
    int speed;
    [SerializeField]
    int maxDistance;
    private Rigidbody2D rbody2D;
    public Animator animator;
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D) && rbody2D.position.x <= maxDistance)
        {
            rbody2D.velocity = (new Vector2(speed, 0));
            animator.SetFloat("speed", 1);
            spriterenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A) && rbody2D.position.x >= -maxDistance)
        {
            rbody2D.velocity = (new Vector2(-speed, 0));
            animator.SetFloat("speed", 1);
            spriterenderer.flipX = true;
        }
        else
        {
            rbody2D.velocity = Vector2.zero;
            animator.SetFloat("speed", 0);
        }
    }
}

