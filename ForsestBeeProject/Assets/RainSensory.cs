using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cast a ray and sends 'Rain' to any possible smoke
/// </summary>
public class RainSensory : MonoBehaviour
{
    private RaycastHit _hit;
    public LayerMask LayerMask;

    private void Awake()
    {
        StartCoroutine(RainDetection());
    }

    IEnumerator RainDetection()
    {
        while (true)
        {
            //Update interval
            yield return new WaitForSeconds(1);
            TryRemoveSmoke();
        }
    }

    public void TryRemoveSmoke()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out _hit, 100, LayerMask))
        {
            var smoke = _hit.transform.GetComponent<Smoke>();
            if (smoke != null)
            {
                smoke.TakeHit(20);
            }
        }
    }
}
