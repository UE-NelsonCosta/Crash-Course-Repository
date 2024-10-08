using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    [field: SerializeField] public static int GlobalCollisionCounter { get; set; } = 0;
    [field: SerializeField] public int SelfCollisionCounter { get; set; } = 0;

    private void OnCollisionEnter(Collision other)
    {
        GlobalCollisionCounter += 1;
        SelfCollisionCounter += 1;
    }
}
