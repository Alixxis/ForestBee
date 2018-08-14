using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour {
	public Transform Path1;
	public Transform Path2;
	public Transform Path3;
	public Transform Path4;
    public Transform Path5;
	public Transform Path6;
	public Transform Path7;
    public Transform Path8;
    public Transform Path9;
    public Transform Path10;
    public Transform Path11;
    public Transform Path12;
    public Transform Path13;
    public Transform Path14;
    public Transform Path15;
    public Transform Path16;
    public Transform Path17;
    public Transform Path18;
    public Transform Path19;
    public Transform Path20;


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
			startPoint = Path1;
			endPoint = Path2;
			t = (time - 0.0f) / 30.0f;  // time - startingtime / duration
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 60)  // time from 30 to 60
		{
			startPoint = Path2;
			endPoint = Path3;
			t = (time - 30.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;

		}

		else if (time < 90) // 
		{
			startPoint = Path3;
			endPoint = Path4;
			t  = (time - 60.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 120)
		{
			startPoint = Path4;
			endPoint = Path5;
			t  = (time - 90.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 150)
		{
			startPoint = Path5;
			endPoint = Path6;
			t  = (time - 120.0f) / 30.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 180)
		{
			startPoint = Path6;
			endPoint = Path7;
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
	


