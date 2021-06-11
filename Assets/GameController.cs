using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalEnemigosNivel;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Enemigos", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetEnemigosDestruidos(){
		return PlayerPrefs.GetInt("Enemigos", 0);
	}

    public void addEnemigoDestruido(){
        int suma = GetEnemigosDestruidos() + 1;
		PlayerPrefs.SetInt("Enemigos", suma);
        if(suma >= totalEnemigosNivel){
            Debug.Log("FIN DEL JUEGO");
            Application.Quit();
        }
	}
}
