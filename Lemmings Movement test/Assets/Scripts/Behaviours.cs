using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviours : ScriptableObject
{
    public abstract Vector2 CalcMove(BoiAgent agent, List<Transform> context, SpawnController herd);
}
