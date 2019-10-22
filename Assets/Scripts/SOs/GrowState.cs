using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GrowState", menuName = "SO/GrowState",order = 0)]
public class GrowState : ScriptableObject
{
    public Sprite sprite;
    public int probability;
    public Color color;
}
