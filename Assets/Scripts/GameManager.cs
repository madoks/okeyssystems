using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource Music;
    public bool Tocar;
    public Flechas Bs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Tocar)
        {
            if(Input.touchCount > 0 || Input.anyKeyDown)
            {
                Tocar = true;
                Bs.hasstarted = true;

                Music.Play();
            }
        }
    }
}
