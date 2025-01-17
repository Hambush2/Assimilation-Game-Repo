﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TopDown2DCharacterController : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    public float slowRate = 0.2f;

    float x = 0.1f;
    float y = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        y = Round(y);
        x = Round(x);
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");


        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            y = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            y = -1;
        }
        else
        {
            if (y > 0)
            {
                    print(y);
                    y = y - slowRate;

            }
            if (y < 0)
            {
                    print(y);
                    y = y + slowRate;

            }
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            x = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            x = -1;
        }
        else
        {
            if (x > 0)
            {
                    print(x);
                    x = x - slowRate;

            }
            if (x < 0)
            {
                    print(x);
                    x = x + slowRate;
            }
        }

        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
    }

    private static Single Round(Single num)
    {

        string hold = Convert.ToString(num);

        int wholeDigit = Convert.ToInt32(num);
        string sWholeDigit = Convert.ToString(wholeDigit);
        int wholeLength = sWholeDigit.Length;

        if (hold.Length <= 2)
        {
            return num;
        }

        if (num < 0)
        {
            return Convert.ToSingle(hold.Substring(0, (wholeLength + 2)));
        }
        else
        {
            return Convert.ToSingle(hold.Substring(0, (wholeLength + 1)));
        }
    }
}
