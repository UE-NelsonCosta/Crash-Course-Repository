using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSlowPlayer : MonoBehaviour
{
    [SerializeField] private float SlowByAmount = 0.20f;
    
    private void OnTriggerEnter(Collider other)
    {
        GeometryDashMovement MovementComponent = other.GetComponent<GeometryDashMovement>();
        if (MovementComponent)
        {
            MovementComponent.ModifyMovementSpeedModfier(-SlowByAmount);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GeometryDashMovement MovementComponent = other.GetComponent<GeometryDashMovement>();
        if (MovementComponent)
        {
            MovementComponent.ModifyMovementSpeedModfier(SlowByAmount);
        }
    }
}
