using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Random = UnityEngine.Random;

public class GrowableObject : MonoBehaviour
{
    [SerializeField] private GameObject nextState;
    [SerializeField] private int threshold;

    public void Update()
    {
        Grow();
    }

    public void Grow()
    {
        if (Random.Range(1, 101) <= threshold)
        {
            
        }
    }
}
