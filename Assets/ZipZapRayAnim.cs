using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class ZipZapRayAnim : MonoBehaviour
{
    public float miliseconds = 0;
    public Image klatka;
    public bool Clicked = false;
    public Sprite[] numbersprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Clicked)
        {
            miliseconds += Time.deltaTime * 100;
            if (miliseconds >= 10f)
            {
                klatka.sprite = numbersprite[1];
            }
            if (miliseconds >= 20f)
            {
                klatka.sprite = numbersprite[2];
            }
            if (miliseconds >= 30f)
            {
                klatka.sprite = numbersprite[3];
            }
            if (miliseconds >= 40f)
            {
                klatka.sprite = numbersprite[4];
            }
            if (miliseconds >= 50f)
            {
                klatka.sprite = numbersprite[5];
            }
            if (miliseconds >= 60f)
            {
                klatka.sprite = numbersprite[6];
            }
            if (miliseconds >= 70f)
            {
                klatka.sprite = numbersprite[7];
            }
            if (miliseconds >= 80f)
            {
                klatka.sprite = numbersprite[8];
            }
            if (miliseconds >= 90f)
            {
                klatka.sprite = numbersprite[9];
            }
            if (miliseconds >= 100f)
            {
                klatka.sprite = numbersprite[10];
            }
            if (miliseconds >= 110f)
            {
                klatka.sprite = numbersprite[11];
            }
            if (miliseconds >= 119f)
            {
                klatka.sprite = numbersprite[12];
            }
            if (miliseconds >= 120f) 
            {
                miliseconds = 0;
            }

        }
    }
}
