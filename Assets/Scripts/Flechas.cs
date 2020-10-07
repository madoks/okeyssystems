using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempo;
    public bool hasstarted;
    // Start is called before the first frame update
    void Start()
    {
        tempo = tempo/ 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasstarted) { }
        else
        {
            transform.position -= new Vector3(0f, tempo * Time.deltaTime, 0f);
        }
             
    }
}
