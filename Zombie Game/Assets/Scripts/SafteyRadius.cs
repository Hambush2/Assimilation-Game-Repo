﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafteyRadius : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<ShootingRange>().enabled = true;
        other.transform.SendMessage("Retreat", SendMessageOptions.DontRequireReceiver);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.transform.SendMessage("RetreatEnd", SendMessageOptions.DontRequireReceiver);
    }
}
