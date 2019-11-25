using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow2D : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5.0f;
    public string targetTag;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag(targetTag).transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, (smoothing * 0.001f));
        }
        else if (target == null)
        {
            target = GameObject.FindWithTag(targetTag).transform;
        }

    }
}
