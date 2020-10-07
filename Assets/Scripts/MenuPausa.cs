using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{
	
	public Text textoRespeto;
	private string escenario;
	public Vector3 diferenciaPosicion;
	public Vector3 nuevaPosicion;

	public void pausa(string escenarioAnterior)
	{
		escenario = escenarioAnterior;
		SceneManager.LoadScene("MenuPausa");	
	}

    public void opciones()
    {
    	nuevaPosicion = new Vector3(-940,1,0);    	
    }

    public void continuar()
    {
        SceneManager.LoadScene(escenario);
    }

    public void volver()
    {
    	nuevaPosicion = new Vector3(0,1,0);
    }

    public void estadisticas()
    {	
    	textoRespeto.text = "Respeto 150";
    	nuevaPosicion = new Vector3(-1940,1,0);	    	
    }

    public void salir()
    {
    	SceneManager.LoadScene("Menu");
    }

    void Start()
    {
    	nuevaPosicion = transform.position;
    }

    void Update()
    {
    	diferenciaPosicion = nuevaPosicion - transform.position;    	
    	transform.position += diferenciaPosicion * 1 * Time.deltaTime;	
    }

}
