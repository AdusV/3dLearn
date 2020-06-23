using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActive : MonoBehaviour
{
    public GameObject sun;
    public bool lighter = false;
    private void OnTriggerEnter(Collider other)
    {
        
        if(lighter)
        {
            sun.SetActive(false);
            lighter = false;    
        }
        else
        {
            sun.SetActive(true);
            lighter = true;
        }
    }
}
