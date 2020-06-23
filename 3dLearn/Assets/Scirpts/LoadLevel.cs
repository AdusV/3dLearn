using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public bool hasKey = false;
    private void OnTriggerEnter(Collider other)
    {
        if (hasKey)
        {
        StartCoroutine("goToNewLevel");

        }
    }
    IEnumerator goToNewLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);

    }    
}
