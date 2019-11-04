using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ZombieTurning : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    public float smoothing = 5.0f;
    float x = 0.0f;
    float y = 0.0f;
    public float adjustmentAngle = 270.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) == true)

        {
            x = 1;
            float rotZ = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);

        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            x = -1;
            float rotZ = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
        }

        if (Input.GetKey(KeyCode.D) == false)
        {
            x = 0;
        }
        if (Input.GetKey(KeyCode.A) == false)
        {
            x = 0;
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            y = 1;
            float rotZ = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
        }
        else if(Input.GetKey(KeyCode.S) == true)
        {
            y = -1;
            float rotZ = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
        }

        if (Input.GetKey(KeyCode.W) == false)
        {
            y = 0;
        }
        if (Input.GetKey(KeyCode.S) == false)
        {
            y = 0;
        }
    }
}
