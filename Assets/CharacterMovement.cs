using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float MovementVelocity = 2.0f;
    [SerializeField] private float JumpForce = 5.0f;

    private bool IsGrounded = true;
    
    private Rigidbody myRigidbody = null;
    
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        UpdateGroundedState();
        
        float VerticalAxis = Input.GetAxis("Vertical");
        float HorizontalAxis = Input.GetAxis("Horizontal");

        myRigidbody.velocity = new Vector3
            (
                HorizontalAxis * MovementVelocity,
                myRigidbody.velocity.y,
                VerticalAxis * MovementVelocity
            );

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            myRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }

    private void UpdateGroundedState()
    {
        RaycastHit HitInformation;
        if (Physics.Raycast(transform.position, Vector3.down, out HitInformation, 1.05f))
        {
            Debug.DrawLine(transform.position, transform.position - Vector3.up * 1.05f, Color.green);
            IsGrounded = true;
            
            Debug.Log(HitInformation.collider.gameObject.name);
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position - Vector3.up * 1.05f, Color.red);
            IsGrounded = false;
        }
    }
}
