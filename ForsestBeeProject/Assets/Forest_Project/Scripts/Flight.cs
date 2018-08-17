using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour {

    public List<Transform> paths = new List<Transform>();
    public FlightData m_FlightData;
    public float updateInterval = 5.0F;
    public float distBeforeRecalculation = 0.1F;
    public float speed = 1;

    public void Init(FlightData flightData)
    {
        m_FlightData = flightData;
    }

    void Start()
	{
        m_FlightData.targetPosition = paths[m_FlightData.currentIndex + 1].position;
    }

    void Update () {

        var targetPosition = m_FlightData.targetPosition;
        var dir = targetPosition - transform.position;
        dir.Normalize();

        transform.position += dir * speed * Time.deltaTime;

        var distance = Vector3.Distance(targetPosition, transform.position);

        if (distance <= distBeforeRecalculation)
        {
            SetNewPosition();
        }
    }

    public void SetNewPosition()
    {
        m_FlightData.currentIndex += 1;
        EnsureIndexAreInRange();
        m_FlightData.targetPosition = paths[m_FlightData.currentIndex].position;
    }

    public void EnsureIndexAreInRange()
    {
        if (m_FlightData.currentIndex >= paths.Count - 1)
            m_FlightData.currentIndex = 0;
    }
}

[System.Serializable]
public class FlightData
{
    public int currentIndex = 0;
    public float startTime = 0;
    public Vector3 targetPosition;
}


