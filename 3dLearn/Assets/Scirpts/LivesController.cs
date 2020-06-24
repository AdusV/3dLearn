using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesController : MonoBehaviour
{
    public int lives;
    public Text livesText;
    private void Start()
    {
            if(PlayerPrefs.HasKey("lives"))
        {//Get sluzy w celu odczytania
            lives = PlayerPrefs.GetInt("lives");
            UpdateLives();
        }
            else
        {
            lives = 3;
            UpdateLives();
        }
    }
    public void UpdateLives()
    {
        livesText.text = "Życia: " + lives.ToString();
    }
    public void ResetLives()
    {
        lives = 3;
        PlayerPrefs.SetInt("lives", lives);
    }
}
