using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class GeometryDashMovement : MonoBehaviour
{
    [SerializeField] private float MovementSpeed = 10.0f;
    [SerializeField] private float JumpForce = 10.0f;

    private bool isGrounded = true;

    private float MovementSpeedModifier = 1.0f;
    
    private Rigidbody myRigidbody;
    private SphereCollider myCollider;
    
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myCollider = GetComponent<SphereCollider>();
    }

    private void Update()
    {
        myRigidbody.velocity = new Vector3
        (
            MovementSpeed * MovementSpeedModifier,
            myRigidbody.velocity.y,
            0.0f
        );

        Vector3 RayStart = transform.position;
        Vector3 RayDirection = Vector3.down;

        float RayLength = myCollider.radius * 1.05f;
        
        if (Physics.Raycast(RayStart, RayDirection, RayLength))
        {
            isGrounded = true;
            Debug.DrawLine(RayStart, RayStart + RayDirection * RayLength, Color.red);
        }
        else
        {
            isGrounded = false;
            Debug.DrawLine(RayStart, RayStart + RayDirection * RayLength, Color.green);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        
        
    }

    public void ModifyMovementSpeedModfier(float SpeedModifier)
    {
        MovementSpeedModifier += SpeedModifier;
    }
}
