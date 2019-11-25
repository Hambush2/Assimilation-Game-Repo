using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomePlayerHuman : MonoBehaviour
{
    public float adjustmentAngle = 0;
    public GameObject prefabToSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerSpawn()
    {
        print("Player Spawn Triggered");

        Vector3 rotationDeg = transform.eulerAngles;
        rotationDeg.z += adjustmentAngle;

        Quaternion rotationRad = Quaternion.Euler(rotationDeg);

        Instantiate(prefabToSpawn, transform.position, rotationRad);

        Destroy(gameObject);
    }
}
