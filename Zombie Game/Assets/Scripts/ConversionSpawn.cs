using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn()
    {
        Vector3 rotationDeg = transform.eulerAngles;
        rotationDeg.z += adjustmentAngle;

        Quaternion rotationRad = Quaternion.Euler(rotationDeg);

        Instantiate(prefabToSpawn, transform.position, rotationRad);
    }
}
