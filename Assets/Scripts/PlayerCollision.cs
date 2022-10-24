using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject restartPanel;
    public Timer varGameObject;

    private AudioSource audio;
    public AudioClip dieSound;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.tag == "Virus")
        {
            restartPanel.SetActive(true);

            varGameObject.GetComponent<Timer>().enabled = false;

            audio.PlayOneShot(dieSound, 1.0f);
        }
    }
}
