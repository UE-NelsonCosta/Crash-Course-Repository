using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    [SerializeField] private Transform ObjectToOrbit = null;
    [SerializeField] private Vector3 Sensitivity = Vector3.one * 100;
    [SerializeField] private Vector3 InvertAxis = Vector3.one;
    [SerializeField] private float DistanceToOrbit = 5.0f;

    private Transform myTransform = null;
    
    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 currentRotation = myTransform.rotation.eulerAngles;

        currentRotation.x += Input.GetAxis("Mouse Y") * Sensitivity.y * InvertAxis.y * Time.deltaTime;
        currentRotation.y += Input.GetAxis("Mouse X") * Sensitivity.x * InvertAxis.x * Time.deltaTime;
        currentRotation.z = 0;
        
        myTransform.rotation = Quaternion.Euler(currentRotation);

        myTransform.position = ObjectToOrbit.position - myTransform.forward * DistanceToOrbit;

    }
}
