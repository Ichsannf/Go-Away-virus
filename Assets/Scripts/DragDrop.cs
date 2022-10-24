using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D col;

    private AudioSource audio;
    public AudioClip virusDrag;
    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<Collider2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCol = Physics2D.OverlapPoint(touchPos);
                if (col == touchedCol)
                {
                    moveAllowed = true;
                    audio.PlayOneShot(virusDrag, 1.0f);
                }
                
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Collider2D touchedCol = Physics2D.OverlapPoint(touchPos);
                if (moveAllowed)
                {
                    transform.position = new Vector2(touchPos.x, touchPos.y);
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }

        }
    }
}
