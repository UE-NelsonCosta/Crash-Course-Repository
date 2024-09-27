using UnityEngine;

public class AddImpulseWhenHittingAnObject : MonoBehaviour
{
    [SerializeField] private float Scalar = 10.0f; 

    private Rigidbody myRigidbody = null;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        
        Vector3 ImpulseDirection = other.contacts[0].normal;
        myRigidbody.AddForce(ImpulseDirection * Scalar, ForceMode.Impulse);
    }
}
