using UnityEngine;
using System.IO;

public class SalvarDatos : MonoBehaviour
{
    public SettingsGame settings;
    public string jsonSettings;
    public string ruta;
    public string [] perfiles;

	void Awake()
    {
        DontDestroyOnLoad(gameObject);        
        Debug.Log(Application.persistentDataPath);
        ruta = Application.persistentDataPath+"/datos";
        if (Directory.Exists(ruta)){
            Debug.Log("Existo");
            perfiles = existenPerfiles();

        }
        else{
            Debug.Log("No existo");
            Directory.CreateDirectory(ruta);
            perfiles = null;
        }
        Debug.Log(perfiles.Length);
        for (int i = 0; i < perfiles.Length; i++){
            Debug.Log(perfiles[i].Replace(ruta+"\\", ""));
        }
    }

    public string [] existenPerfiles()
    {      
        return Directory.GetDirectories(ruta);
    }

    public void newPerfil(string nombre)
    {
        
        if (!File.Exists(ruta))
        {            
            settings = new SettingsGame();
            settings.volumen = 100;
            settings.escenario = "Menu";
            settings.player = new PlayerGame();
            settings.player.prendas = new[]{
                new Garment()
            };

            string jsonSettings = JsonUtility.ToJson(settings);
            File.WriteAllText(ruta, jsonSettings);        
        }
        else
        {
                    
            jsonSettings  = File.ReadAllText(Application.persistentDataPath+"/salvarDatos.json");
            settings = JsonUtility.FromJson<SettingsGame>(jsonSettings);
            Debug.Log(settings.escenario);
        }
    }
   
}

[System.Serializable]
public class SettingsGame
{
    public string nombre;
    public int volumen;
    public string escenario;
    public PlayerGame player;
    public NPCGame [] npcs;    
}

[System.Serializable]
public class PlayerGame
{
    public string nombre;
    public string genero;
    public int respeto;
    public int estilo;
    public int fama;
    public int elegancia;
    public Garment [] prendas;
}

[System.Serializable]
public class NPCGame
{
    public string nombre;
    public string genero;
    public string ocupacion;
    public Dialogue dialogos; 
    public int amistad;
    public Garment torso;
    public Garment piernas;
    public Garment cabeza;
    public Garment pies;
    public Garment vestido;
}

[System.Serializable]
public class Dialogue
{
    public string dialogo;
    public int nivel;
}

[System.Serializable]
public class Garment
{
    public string tipo;
    public string nombre;
    public double precio;    
}