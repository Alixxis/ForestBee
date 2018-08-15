using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class AppManager : MonoBehaviour
/*{
    public static AppManager Instance;
    
    public Transform firstredBee;
    public List<Transform> spawnPoints = new List<Transform>();
    public GameObject RedBee;

    public int redBeeCount = 0;
    public int maxRedBee = 20;

    private void Awake()
    {
        Instance = this;
        firstredBee.transform.position = spawnPoints[0].position;
        firstredBee.transform.rotation = spawnPoints[0].rotation;
    }

    //This is actually a spwaner script but there's not much in the app
    public void OnRedBeeCreated(RedBee redBee, Vector3 position, Quaternion rotation, Transform parent)
    {
        if (redBeeCount < maxRedBee)
        {
            redBeeCount++;
            //OnRedBeeCounted();

            var newRedBee = Instantiate(redBee, position, rotation);
            newRedBee.transform.parent = parent;
            newRedBee.transform.position = spawnPoints[redBeeCount].position;
            newRedBee.transform.rotation = spawnPoints[redBeeCount].rotation;

        }

    }

}
*/
