using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    public float moveSpeed;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPos.x > 0)
            {
                rigidbody2D.velocity = Vector2.left * moveSpeed;
                //move left
            }
            else
            {
                //move right
                rigidbody2D.velocity = Vector2.right * moveSpeed;
            }

        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
