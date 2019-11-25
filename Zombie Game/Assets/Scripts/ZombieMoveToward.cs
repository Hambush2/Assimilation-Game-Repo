using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoveToward : MonoBehaviour
{
    public List<GameObject> hoomanz = new List<GameObject>();
     GameObject[] hoomans;
    public Transform target;
    public float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        //int len = GameObject.FindGameObjectsWithTag("HumanNPC").Length + 1;

        //hoomans = new GameObject[GameObject.FindGameObjectsWithTag("HumanNPC").Length + 1];

        OnDetectHoomans();
        //hoomans[hoomans.Length - 1] = GameObject.FindWithTag("Player");
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


    public void OnDetectHoomans()
    {
        print("detecting new hoomans");
        
        Invoke("Delay", 0.5f);
    }

    void Delay()
    {
        hoomans = GameObject.FindGameObjectsWithTag("HumanNPC");
        hoomanz.Clear();

        for (int i = 0; i < hoomans.Length; i++)
        {
            hoomanz.Add(hoomans[i]);
        }

        hoomanz.Add(GameObject.FindGameObjectWithTag("Player"));



        FindTarget();
    }


    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void FindTarget()
    {
        float dist = 9999;

        for (int i = 0; i < hoomanz.Count; i++)
        {
            if (hoomanz[i] != null)
            {


                float distance = Vector3.Distance(hoomanz[i].transform.position, transform.position);

                if (distance < dist)
                {
                    target = hoomanz[i].transform;
                    dist = distance;
                }
            }
        }
    }
}
