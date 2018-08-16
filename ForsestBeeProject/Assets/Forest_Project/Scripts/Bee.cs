using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bee : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //Notify BeeManager that I've been hit by invoking the OnBeeHit event
        if(BeeManager.OnBeeHit != null)
            BeeManager.OnBeeHit.Invoke(this);
    }
}
