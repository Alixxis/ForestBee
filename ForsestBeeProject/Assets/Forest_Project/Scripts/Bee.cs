using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bee : MonoBehaviour, IPointerClickHandler
{
    public Flight m_Flight;

    void Awake()
    {
        m_Flight = GetComponent<Flight>();
    }

    public void InitData(Bee bee)
    {
        m_Flight.paths = bee.m_Flight.paths;
        m_Flight.m_FlightData = bee.m_Flight.m_FlightData;
    }

    public string beeName = "";
    public Color beeColor = Color.red;

    public void OnPointerClick(PointerEventData eventData)
    {
        //Notify BeeManager that I've been hit by invoking the OnBeeHit event
        if(BeeManager.OnBeeHit != null)
            BeeManager.OnBeeHit.Invoke(this);
    }
}

//Unity knows it needs to (SAVE) these
[System.Serializable]
public class BeeData
{
    public string beeName = "";
    public Color beeColor = Color.red;
}