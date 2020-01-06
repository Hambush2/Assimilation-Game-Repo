using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyPathFinder : MonoBehaviour
{
    //public Transform[] targets;
    private IAstarAI ai;
    public List<GameObject> hoomanz = new List<GameObject>();
    GameObject[] hoomans;
    public Transform target;
    public string NPCTag;
    public string playerTag;
    // Start is called before the first frame update
    private void Start()
    {
        ai = GetComponent<IAstarAI>();
        OnDetectHoomans();
    }

    // Update is called once per frame
    private void Update()
    {
        FindTarget();
        if (target != null && ai !=null)
        {

            ai.destination = target.position;
            ai.SearchPath();
        }

    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void FindTarget()
    {
        float dist = 99999999999999;

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

    public void OnDetectHoomans()
    {
        print("detecting new hoomans");

        Invoke("Delay", 0.5f);
    }

    void Delay()
    {
        hoomans = GameObject.FindGameObjectsWithTag(NPCTag);
        hoomanz.Clear();

        for (int i = 0; i < hoomans.Length; i++)
        {
            hoomanz.Add(hoomans[i]);
        }

        hoomanz.Add(GameObject.FindGameObjectWithTag(playerTag));



        FindTarget();
    }
}
