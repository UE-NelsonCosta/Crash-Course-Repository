using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeometryDashGameMode : MonoBehaviour
{
    private void Start()
    {
        HealthComponent playerHealth = FindObjectOfType<HealthComponent>();
        if (playerHealth)
        {
            playerHealth.OnHealthChangedEvent.AddListener( OnPlayerTookDamage );
        }
    }

    private void OnPlayerTookDamage(float normalizeHealthValue)
    {
        if (normalizeHealthValue <= 0.0f)
        {
            SceneManager.LoadScene("4. GeometryDashClone");
        }
    }
}
