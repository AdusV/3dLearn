using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text recordText;
    public int points;
    public int record;
    public Text counterText;

    private void Start()
    {
        record = PlayerPrefs.GetInt("record");
        //Wczytywanie rekordu z poprzedniej sesji
        recordText.text = record.ToString();
    }
    public bool isNewRecord()
    {
       return points > record;

    }
    public void UpdateRecord()
    {
        record = points;
        recordText.text = record.ToString();
        //Zapisywanie Biezacego rekordu pkt
        PlayerPrefs.SetInt("record", record);
    }
    public void ClearRecord()
    {
        record = 0;
        //Aktualizacja rekordu na ekranie
        recordText.text = record.ToString();
        PlayerPrefs.DeleteKey("record");  
    }
}
