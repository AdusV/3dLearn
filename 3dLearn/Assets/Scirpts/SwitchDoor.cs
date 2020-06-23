using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    public GameObject futryna;
    public string massage;
    private void OnTriggerEnter(Collider other)
    {
        futryna.SendMessage(massage);
    }
}
