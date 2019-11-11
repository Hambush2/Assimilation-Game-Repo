using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{
    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;

    // Start is called before the first frame update
    private void Start()
    {
        if (repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            Invoke("OnTimerComplete", time);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTimerComplete()
    {
        onTimerComplete.Invoke();
    }
}
