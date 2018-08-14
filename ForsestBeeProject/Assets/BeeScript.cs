using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BeeScript : MonoBehaviour {

    private NavMeshAgent nma = null;
    private GameObject[] RandomPoint;
    private int CurrentRandom;


	// Use this for initialization
	void Start ()
    {
        nma = this.GetComponent<NavMeshAgent>();
        RandomPoint = GameObject.FindGameObjectsWithTag("RandomPoint");        

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (nma.hasPath == false)
        {
            CurrentRandom = Random.Range(0, RandomPoint.Length + 1);
            nma.SetDestination(RandomPoint[CurrentRandom].transform.position);

        }



	}
}
