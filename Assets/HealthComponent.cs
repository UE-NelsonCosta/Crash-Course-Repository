using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnHealthChanged : UnityEvent<float> { }

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float MaxHealth = 5.0f;
    private float CurrentHealth = 0.0f;
    private float NormalizedHealth = 0.0f;

    public OnHealthChanged OnHealthChangedEvent;
    
    private void Start()
    {
        CurrentHealth = MaxHealth;
        NormalizedHealth = CurrentHealth / MaxHealth;
        
        OnHealthChangedEvent.Invoke(NormalizedHealth);
    }

    public void DealDamage(float DamageToDeal)
    {
        CurrentHealth -= DamageToDeal;
        NormalizedHealth = CurrentHealth / MaxHealth;

        OnHealthChangedEvent.Invoke(NormalizedHealth);
    }
}
