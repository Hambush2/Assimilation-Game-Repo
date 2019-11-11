using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EnemySpawnedEvent : UnityEvent<Transform> { }
public class ZombieNPC : MonoBehaviour
{
    public EnemySpawnedEvent onSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        onSpawn.Invoke(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
