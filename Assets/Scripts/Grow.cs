using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Grow : MonoBehaviour
{
    [SerializeField]private GrowState[] states;
    private Queue<GrowState> _states;
    private void Start()
    {
        _states = new Queue<GrowState>();
        ArrayToQueue();
    }

    private void Update()
    {
        
    }

    private void ArrayToQueue()
    {
        foreach (var t in states)
            _states.Enqueue(t);
    }
}
