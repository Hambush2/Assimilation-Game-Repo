using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothLookAtTarget : MonoBehaviour
{
    GameObject [] hoomans;
    public Transform target;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 270.0f;
    public string targetTag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        hoomans = GameObject.FindGameObjectsWithTag(targetTag);
    }

    // Update is called once per frame
    private void Update()
    {
        FindTarget();
        if (target != null)
        {
            Vector3 difference = target.position - transform.position;

            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

            Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));

            transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * smoothing);
        }
    }

    public void setTarget (Transform newTarget)
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
