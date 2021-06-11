using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaObj : MonoBehaviour
{
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy"){
            Destroy(other.gameObject);
            GameObject.Find("GameController").GetComponent<GameController>().addEnemigoDestruido();
        }
    }
}
