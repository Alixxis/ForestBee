using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bee : MonoBehaviour
{
    public Flight m_Flight;
    private bool CanHit = true;
    private Collider _collider;
    void Awake()
    {
        m_Flight = GetComponent<Flight>();
        _collider = GetComponent<Collider>();
    }

    public void InitData(Bee bee)
    {
        m_Flight.paths = bee.m_Flight.paths;
        m_Flight.m_FlightData = bee.m_Flight.m_FlightData;
    }

    public string beeName = "";
    public Color beeColor = Color.red;

    //oncollisionm 

    public void OnTriggerEnter(Collider collider)
    {
        var mushroomProjectile = collider.gameObject.GetComponent<MushroomProjectile>();

        if (mushroomProjectile)
        {
            //Notify BeeManager that I've been hit by invoking the OnBeeHit event
            if (BeeManager.OnBeeHit != null)
                BeeManager.OnBeeHit.Invoke(this);

            Destroy(mushroomProjectile);
        }
    }

    public void SetColliderState(bool state)
    {
        _collider.enabled = state;
    }
}

//Unity knows it needs to (SAVE) these
[System.Serializable]
public class BeeData
{
    public string beeName = "";
    public Color beeColor = Color.red;
}