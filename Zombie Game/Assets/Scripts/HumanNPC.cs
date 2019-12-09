using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class HumanSpawnedEvent : UnityEvent<Transform> { }
public class HumanNPC : MonoBehaviour
{
    public HumanSpawnedEvent onSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GameObject zPlayer = GameObject.FindWithTag("Zombie Player");
        onSpawn.Invoke(zPlayer.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
