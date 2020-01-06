using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ShootingRange : MonoBehaviour
{
    private IAstarAI ai;
    public List<GameObject> hoomanz = new List<GameObject>();
    GameObject[] hoomans;
    public Transform target;
    public bool isStopped = false;
    public float retreatSpeed = 3.0f;
    //public Transform testTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (target != null && ai != null && !isStopped)
        {
            
            ai.destination = target.position;
            ai.SearchPath();
            print("pathing Retreat");
        }
    }

    public void Retreat()
    {
        GetComponent<EnemyPathFinder>().enabled = false;

        ai = GetComponent<IAstarAI>();
        OnDetectHoomans();

        


        //get vector towards object, invert to move away, not functional
    }

    private void FindTarget()
    {
        print("Finding Target");
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

    private void RetreatEnd()
    {
        GetComponent<EnemyPathFinder>().enabled = true;
        GetComponent<ShootingRange>().enabled = false;
    }

    private void FillList()
    {
        hoomans = GameObject.FindGameObjectsWithTag("Zombie NPC");
        hoomanz.Clear();

        for (int i = 0; i < hoomans.Length; i++)
        {
            hoomanz.Add(hoomans[i]);
        }

        hoomanz.Add(GameObject.FindGameObjectWithTag("Zombie Player"));

        FindTarget();
    }

    public void OnDetectHoomans()
    {
        print("detecting retreat point");

        Invoke("Delay", 0.25f);
    }

    void Delay()
    {
        hoomans = GameObject.FindGameObjectsWithTag("WorldObject");
        hoomanz.Clear();

        for (int i = 0; i < hoomans.Length; i++)
        {
            hoomanz.Add(hoomans[i]);
        }

        FindTarget();
    }
}
