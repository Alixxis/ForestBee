using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public Transform SmokeContainer;
    public float MaxHealth = 100;
    public float Health = 100;

    private void Awake()
    {
        _startScale = SmokeContainer.localScale;
    }

    public void TakeHit(float amount)
    {
        Health -= amount;

        if (Health <= 0)
            Health = 0;

        ApplySmokeLevel();
    }

    public void ApplySmokeLevel()
    {
        var remainingPercentage = Health / MaxHealth;
        SmokeContainer.localScale = Vector3.Lerp(Vector3.zero, _startScale, remainingPercentage);
    }

    private Vector3 _startScale;
}
