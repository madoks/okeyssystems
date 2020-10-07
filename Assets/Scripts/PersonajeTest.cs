using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeTest : MonoBehaviour
{
	public float Acc1;
    private Animator animar;
    public float Acc2;

	void Start()
    {
    	animar = GetComponent<Animator>();
    	Acc1 = -1;
    	Acc2 = -1;
    }
    void Update()
    {
    	animar.SetFloat("Acc1", Acc1);
    	animar.SetFloat("Acc2", Acc2);
    }
}
