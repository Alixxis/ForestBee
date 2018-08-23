using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeFriend : MonoBehaviour
{
	public Transform T1;
	public Transform T2;
	public Transform T3;
	
void Update () {
        Transform startPoint;
        Transform endPoint;
        float time = Time.time;
        float t = time;

        if (time < 30)
        {  // time from 0 to 15
            startPoint = T1;
            endPoint = T2;
            t = (time - 0.0f) / 15.0f;  // time - startingtime / duration
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 30)  // time from 30 to 60
        {
            startPoint = T2;
            endPoint = T3;
            t = (time - 15.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;

        }

    }

}



