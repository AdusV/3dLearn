
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //Czy drzwi sa otwarte
    public bool isOpen = false;
    //9,8 11,3
    public float openPostion;
    public float closePosition;
    private float newX;
    private float velocity;
    public float smoothTime;
    public GameObject doorObject;
    public float target;
    private void Start()
    {
        target = closePosition;
    }

    private void Update()
    { 
        //Plynna zmiana wartosci w czasie
        newX = Mathf.SmoothDamp(doorObject.transform.localPosition.x, target, ref velocity, smoothTime);
        doorObject.transform.localPosition = new Vector3(newX, doorObject.transform.localPosition.y, doorObject.transform.localPosition.z);
    }
    public void OpenDoor()
    {
        target = openPostion;
        isOpen = true;
    }
    public void CloseDoor()
    {
        target = closePosition;
        isOpen = false;
    }
}
