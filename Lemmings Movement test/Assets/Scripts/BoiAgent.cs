using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class BoiAgent : MonoBehaviour
{


    Collider2D boiCollider;
    public Collider2D BoiCollider { get { return boiCollider; } }

    void Start()
    {
        boiCollider = GetComponent<Collider2D>();
    }

      
}
