using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator.SetBool("running", Input.GetAxisRaw("Horizontal") != 0); // -1, 0, 1
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody2D.velocity = new Vector2(-5, Rigidbody2D.velocity.y);
            transform.localScale = new Vector2(-1, 1);
            Animator.SetBool("crouching", false);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody2D.velocity = new Vector2(5, Rigidbody2D.velocity.y);
            transform.localScale = new Vector2(1, 1);
            Animator.SetBool("crouching", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 5);
            Animator.SetBool("crouching", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 0);
            Animator.SetBool("crouching", true);
        }

    }
}
