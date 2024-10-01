using UnityEngine;

public class OnTriggerDealDamage : MonoBehaviour
{
    //[SerializeField] private float DamageToDeal = 1.0f;

    [field: SerializeField] public float DamageToDeal { get; private set; } = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HealthComponent healthComponent = other.GetComponent<HealthComponent>();
            if (healthComponent)
            {
                healthComponent.DealDamage(DamageToDeal);
            }
        }
    }
}
