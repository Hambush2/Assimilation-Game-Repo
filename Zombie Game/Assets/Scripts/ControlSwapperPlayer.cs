using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSwapperPlayer : MonoBehaviour
{
    GameObject[] hoomans;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        hoomans = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindTarget()
    {
        float dist = 9999;

        for (int i = 0; i < hoomans.Length; i++)
        {
            float distance = Vector3.Distance(hoomans[i].transform.position, transform.position);

            if (distance < dist)
            {
                target = hoomans[i].transform;
                dist = distance;
            }

        }

        target.transform.SendMessage("PlayerSpawn", SendMessageOptions.DontRequireReceiver);
    }
}
