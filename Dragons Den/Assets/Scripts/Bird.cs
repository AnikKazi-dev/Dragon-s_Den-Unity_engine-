using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
   
    public float speed = 0.0f;
    int angle = 0;
    int maxAngle = 20;
    int minAngle = -20;


    public ScoreScript scoreScript;

    public GameObject DragonFire;

    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false)
        {


            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.velocity = new Vector2(rb.velocity.x, speed);
            }
            if (Input.GetMouseButtonDown(1))
            {
                DragonFire.SetActive(true);
            }
            if (Input.GetMouseButtonUp(1))
            {
                DragonFire.SetActive(false);
            }


        }
        birdRotation();
    }

    void birdRotation ()
    {


        if (rb.velocity.y > 0)
        {
            rb.gravityScale = 0.8f;
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }

        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = 0.6f;
            if (rb.velocity.y < -1.3f)
            {
                if (angle >= minAngle)
                {
                    angle = angle - 3;
                }

            }


        }

        transform.rotation = Quaternion.Euler(0, 0, angle);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("trigger")) {

         
             scoreScript.Scored();
          
           
        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            
                
                gameManager.GameOver();

            //Debug.Log("in ground");


        }
        if (collision.gameObject.CompareTag("spike"))
        {
            gameManager.GameOver();
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameManager.GameOver();
        }
    }
}
