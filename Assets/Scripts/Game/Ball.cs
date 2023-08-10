using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D ball;
    public float bounceForce;
    bool gameStarted = false;
    private void Awake()
    {
        ball = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.anyKeyDown)
            {
                Bounce();
                gameStarted = true;
                GameManager.instance.GameStart();
            }
        }
    }

    private void Bounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);
        ball.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "fall-check")
        {
            GameManager.instance.Restart();
        }
        if(collision.gameObject.tag == "paddle")
        {
            GameManager.instance.ScoreUp();
        }
    }
}
