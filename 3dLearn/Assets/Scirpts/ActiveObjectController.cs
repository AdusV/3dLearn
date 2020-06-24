using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjectController : MonoBehaviour
{
    public GameObject target;
    public string message;
    private void OnMouseDown()
    {
        target.SendMessage(message);
    }
}
