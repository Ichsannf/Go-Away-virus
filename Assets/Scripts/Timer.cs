using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TMP_Text timerText;
    [SerializeField] TMP_Text highscore;
    private float startTime;
    public float time = 0;
    public int GameTime = 0;


    private void Start()
    {
        startTime = Time.time;
        if (PlayerPrefs.HasKey("HighScore") == true)
        {
            highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("f2") + " Points";
        }
        else 
        {
            highscore.text = "don't have a high score yet";
        }        
    }

    private void Update()
    {

        float t = Time.time - startTime;
        string seconds = (t).ToString("f2");
        timerText.text = seconds + " Points";
        if (t > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", t);
            highscore.text = seconds + " Points";
        }
    }
    public void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

}
