using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoveToward : MonoBehaviour
{
    GameObject[] hoomans;
    public Transform target;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        hoomans = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        FindTarget();
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }

    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void FindTarget()
    {
        float dist = 9999;

        for (int i = 0; i < hoomans.Length; i++)
        {
            if (hoomans[i] != null)
            {


                float distance = Vector3.Distance(hoomans[i].transform.position, transform.position);

                if (distance < dist)
                {
                    target = hoomans[i].transform;
                    dist = distance;
                }
            }
        }
    }
}
