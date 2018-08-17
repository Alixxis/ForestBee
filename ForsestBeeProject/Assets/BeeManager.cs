﻿using System;
using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// The BeeManager manags the live cycle of bees
/// </summary>
public class BeeManager : MonoBehaviour
{
    public static Action<Bee> OnBeeHit;

    public Bee m_BeeBluePrefab;

    public Transform firstBlueBee;  //testing
    public List<Transform> spawnPoints = new List<Transform>(); //testing

    private void Awake()
    {
        //Subscribe BeeHit method to OnBeeHit event that gets called by Bee
        OnBeeHit += BeeHit;

        firstBlueBee.transform.position = spawnPoints[0].position; //testing
        firstBlueBee.transform.rotation = spawnPoints[0].rotation; //testing
    }

    private void OnDestroy()
    {
        //Unsubscribe BeeHit method to OnBeeHit event that gets called by Bee
        OnBeeHit -= BeeHit;
    }

    //When a bee gets hit by a projectile (mushroom?)
    public void BeeHit(Bee bee) 
    {
        //Create a new bee
        CreateBee(bee, m_BeeBluePrefab,bee.transform.position, bee.transform.rotation);

        //Destroy old one
        DestroyBee(bee.gameObject);
    }

    //Generates a new bee at X location
    public void CreateBee(Bee currentBee,Bee newBee,Vector3 position, Quaternion rotation)
    {
        var beeInstance = Instantiate(newBee, position, rotation);
        beeInstance.InitData(currentBee);
        beeInstance.gameObject.SetActive(true);
    }

    //Destroy 
    public void DestroyBee(GameObject go)
    {
        Destroy(go);
    }

}