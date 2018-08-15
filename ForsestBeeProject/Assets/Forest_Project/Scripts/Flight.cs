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


		if (time < 15) {  // time from 0 to 15
			startPoint = Path1;
			endPoint = Path2;
			t = (time - 0.0f) / 15.0f;  // time - startingtime / duration
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 30)  // time from 15 to 30
		{
			startPoint = Path2;
			endPoint = Path3;
			t = (time - 15.0f) / 15.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;

		}

		else if (time < 45) // 
		{
			startPoint = Path3;
			endPoint = Path4;
			t  = (time - 30.0f) / 15.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 60)
		{
			startPoint = Path4;
			endPoint = Path5;
			t  = (time - 45.0f) / 15.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 75)
		{
			startPoint = Path5;
			endPoint = Path6;
			t  = (time - 60.0f) / 15.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

		else if (time < 90)
		{
			startPoint = Path6;
			endPoint = Path7;
			t  = (time - 75.0f) / 15.0f;
			transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
		}

        else if (time < 105)
        {
            startPoint = Path7;
            endPoint = Path8;
            t = (time - 90.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 120)
        {
            startPoint = Path8;
            endPoint = Path9;
            t = (time - 105.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 135)
        {
            startPoint = Path9;
            endPoint = Path10;
            t = (time - 120.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 150)
        {
            startPoint = Path10;
            endPoint = Path11;
            t = (time - 135.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 165)
        {
            startPoint = Path11;
            endPoint = Path12;
            t = (time - 150.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 180)
        {
            startPoint = Path12;
            endPoint = Path13;
            t = (time - 165.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 195)
        {
            startPoint = Path13;
            endPoint = Path14;
            t = (time - 180.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 210)
        {
            startPoint = Path14;
            endPoint = Path15;
            t = (time - 195.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 225)
        {
            startPoint = Path15;
            endPoint = Path16;
            t = (time - 210.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 240)
        {
            startPoint = Path16;
            endPoint = Path17;
            t = (time - 225.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 255)
        {
            startPoint = Path17;
            endPoint = Path18;
            t = (time - 240.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 270)
        {
            startPoint = Path18;
            endPoint = Path19;
            t = (time - 255.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

        else if (time < 285)
        {
            startPoint = Path19;
            endPoint = Path20;
            t = (time - 270.0f) / 15.0f;
            transform.position = (1.0f - t) * startPoint.position + (t) * endPoint.position;
        }

    }

}
	



