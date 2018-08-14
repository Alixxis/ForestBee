using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour {
	public Transform S1;
	public Transform T1;
	public Transform T2;
	public Transform T3;
	public Transform T4;
	public Transform T5;
	public Transform T6;


void Start()
	{
		//transform.position = startPoint.position;

	}

void Update () {
		Transform startPoint;
		Transform endPoint;
		float time = Time.time;
		float t = time;


		if (time < 30) {  // time from 0 to 30
			startPoint = S1;
			endPoint = T1;
			t = (time - 0.0f) / 30.0f;  // time - startingtime / duration
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 60)  // time from 30 to 60
		{
			startPoint = T1;
			endPoint = T2;
			t = (time - 30.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;

		}

		else if (time < 90) // 
		{
			startPoint = T2;
			endPoint = T3;
			t  = (time - 60.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 120)
		{
			startPoint = T3;
			endPoint = T4;
			t  = (time - 90.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 150)
		{
			startPoint = T4;
			endPoint = T5;
			t  = (time - 120.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 180)
		{
			startPoint = T5;
			endPoint = T6;
			t  = (time - 150.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}
	
	
	}

}
	



/*		float t = time;

		//print (Mathf.Abs(transform.position.x - endPoint.transform.position.x));

		if ((Mathf.Abs (transform.position.x - midPoint.transform.position.x) < 0.1) || (Mathf.Abs (transform.position.z - midPoint.transform.position.z) < 0.1) || (Mathf.Abs (transform.position.y - midPoint.transform.position.y) < 0.1)) 
			
		{	
			transform.position = (-1.0f - t) * startPoint.position + (t) * midPoint.position;
			//transform.forward = -1.0f * startPoint.position + 1.0f * endPoint.position;
		}

		if ((Mathf.Abs (transform.position.x - endPoint.transform.position.x) > 0.1) || (Mathf.Abs (transform.position.z - endPoint.transform.position.z) > 0.1) || (Mathf.Abs (transform.position.y - endPoint.transform.position.y) > 0.1)) 

		{	
			transform.position = (1.0f - t) * midPoint.position + (t) * endPoint.position;
			//transform.forward = -1.0f * startPoint.position + 1.0f * endPoint.position;
		}
*/
	


