using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown2DCharacterController : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    public float slowRate = 0.5f;

    float x = 0;
    float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");


        if(Input.GetKey(KeyCode.W) == true)
        {
            y = 1;
        }
        else if (Input.GetKey(KeyCode.S) == true)
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

        if (Input.GetKey(KeyCode.D) == true)
        {
            x = 1;
        }
        else if (Input.GetKey(KeyCode.A) == true)
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
}
