using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FailDetector : MonoBehaviour
{
    public GameObject panelGameOver;
    public LivesController livesController;
   private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (livesController.lives > 0)
            {
                livesController.lives -= 1;
                //Set sluzy w celu zapmietania 
                PlayerPrefs.SetInt("lives", livesController.lives);
                livesController.UpdateLives();
                StartCoroutine(BeginStart());

            }
            else
            {
                panelGameOver.SetActive(true);
                livesController.ResetLives();

                StartCoroutine(BeginStart());
            }
            
        }
      
        IEnumerator BeginStart()
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(0);
        }
        
    }
}
