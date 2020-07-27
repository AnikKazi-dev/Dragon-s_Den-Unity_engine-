﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float groundWidth;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.CompareTag("ground"))
        {
            box = GetComponent<BoxCollider2D>();
            groundWidth = box.size.x;

           
        }

        if (gameObject.CompareTag("trigger"))
        {
           
        }

        //Debug.Log(box.size.x);
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.gameOver == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

            if (transform.position.x <= -groundWidth)
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);

            }

        }

    }
}
