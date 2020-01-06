using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            print("Zombie Victory");
        }
        if(GameObject.FindGameObjectWithTag("Zombie Player") == null)
        {
            print("Human Victory");
        }
    }
}
