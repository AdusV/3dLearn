using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLevel : MonoBehaviour
{
    public AudioClip audioClip;
    public LoadLevel loadLevel;
    private void OnTriggerEnter(Collider other)
    {

        Destroy(this.gameObject);
        loadLevel.hasKey = true;
        AudioSource.PlayClipAtPoint(audioClip, transform.position);

    }
}
