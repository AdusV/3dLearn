using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamentsCoin : MonoBehaviour
{
    public AudioClip audioClip;
    public PointsCounter counter;
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        counter.points += 5;
        if(counter.isNewRecord())
        {
            counter.UpdateRecord();
        }
        counter.counterText.text = counter.points.ToString();
        Destroy(this.gameObject);       
      
        
    }
 
   
}
