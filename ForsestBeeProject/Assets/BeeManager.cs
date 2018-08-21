using System.Collections;
using System;
using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// The BeeManager manags the live cycle of bees
/// </summary>
public class BeeManager : MonoBehaviour
{
    public static Action<Bee> OnBeeHit;

    public Bee m_BeeBluePrefab;
    public Bee m_YellowBeePrefab; //testing

    public Material blueSky; //testing

    public Transform firstYellowBee;  //testing
    public GameObject WaterfallEffect;

    public Transform firstBlueBee;  
    public List<Transform> spawnPoints = new List<Transform>(); 

    public int BlueBeeCount = 0;  //testing
    public int MaxBlueBee = 19;  //testing

    public int YellowBeeCount = 0;  //testing
    public int MaxYellowBee = 19;   //testing

    private Bee mBeeToSpawn;
    private void Awake()
    {
        //Subscribe BeeHit method to OnBeeHit event that gets called by Bee
        OnBeeHit += BeeHit;

        firstBlueBee.transform.position = spawnPoints[0].position; 
        firstBlueBee.transform.rotation = spawnPoints[0].rotation;

        mBeeToSpawn = m_BeeBluePrefab;
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
        CreateBee(bee, mBeeToSpawn, bee.transform.position, bee.transform.rotation);

        if (BlueBeeCount == MaxBlueBee)
        {
            mBeeToSpawn = m_YellowBeePrefab;
            BlueBeeCount = 0;            
        }

        if (YellowBeeCount == MaxYellowBee)            
        {
            
            RenderSettings.skybox = blueSky;
            Instantiate(WaterfallEffect, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.SetActive(true);
        }

        YellowBeeCount += 1;
        BlueBeeCount += 1;
        //Destroy (whichever bee that got hit)
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
