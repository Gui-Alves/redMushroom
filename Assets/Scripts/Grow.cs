using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Random = UnityEngine.Random;

public class Grow : MonoBehaviour
{
    [SerializeField]private GrowState[] states;
    private Queue<GrowState> _states;
    private GrowState curentState;
    private SpriteRenderer sprite;
    
    private void Start()
    {
        _states = new Queue<GrowState>();
        sprite = GetComponent<SpriteRenderer>();
        ArrayToQueue();
        GetStateInformation();
    }

    private void Update()
    {
        
        if (Random.Range(1, 100) <= curentState.probability)
        {
            _states.Dequeue();
            GetStateInformation();
        }
    }

    private void ArrayToQueue()
    {
        foreach (var t in states)
            _states.Enqueue(t);
    }

    private void GetStateInformation()
    {
        curentState = _states.Peek();
        sprite.sprite = curentState.sprite;
        sprite.color = curentState.color;
    }
}
