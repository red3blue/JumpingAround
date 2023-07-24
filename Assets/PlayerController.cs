using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody2D.velocity = new Vector2(-5, Rigidbody2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody2D.velocity = new Vector2(5, Rigidbody2D.velocity.y);
        }
        else
        {
            Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 5);
        }
    }
}
