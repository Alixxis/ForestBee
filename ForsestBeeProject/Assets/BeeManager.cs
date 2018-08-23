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
    public Bee m_YellowBeePrefab; 

    public Material blueSky;
    public Material magicSky;

    public Transform firstYellowBee;  
    public Transform firstBlueBee;  
    public List<Transform> spawnPoints = new List<Transform>(); 

    public int BlueBeeCount = 0;  
    public int MaxBlueBee = 19;  

    public int YellowBeeCount = 0;  
    public int MaxYellowBee = 19;

    private Bee mBeeToSpawn;
    private void Awake()
    {
        //Subscribe BeeHit method to OnBeeHit event that gets called by Bee
        OnBeeHit += BeeHit;

        firstBlueBee.transform.position = spawnPoints[0].position; 
        firstBlueBee.transform.rotation = spawnPoints[0].rotation;

        mBeeToSpawn = m_BeeBluePrefab;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            var bees = FindObjectsOfType<Bee>();
            foreach (var bee in bees)
            {
                BeeHit(bee);
            }
        }
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

        if (mBeeToSpawn == m_BeeBluePrefab)
        {
            BlueBeeCount += 1;
        }

        if (BlueBeeCount == MaxBlueBee)
        {
            mBeeToSpawn = m_YellowBeePrefab;
            RenderSettings.skybox = blueSky;

            //Renable colliders on all bees
            var bees = FindObjectsOfType<Bee>();

            foreach (var beeInstance in bees)
            {
                beeInstance.SetColliderState(true);
            }
        }

        if (mBeeToSpawn == m_YellowBeePrefab)
        {
            YellowBeeCount += 1;
        }

        if (YellowBeeCount == MaxYellowBee)
        {
            RenderSettings.skybox = magicSky;
        }

        //Destroy (whichever bee that got hit)
        DestroyBee(bee.gameObject);
    }

    //Generates a new bee at X location
    public void CreateBee(Bee currentBee,Bee newBee,Vector3 position, Quaternion rotation)
    {
        var beeInstance = Instantiate(newBee, position, rotation);
        beeInstance.InitData(currentBee);
        beeInstance.gameObject.SetActive(true);

        //Disable collider
        beeInstance.SetColliderState(false);
    }

    //Destroy 
    public void DestroyBee(GameObject go)
    {
        Destroy(go);
    }

}
