﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource energiaSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("-> " + other.gameObject.tag);
        if(other.gameObject.tag == "Energy"){
            energiaSound.Play();
            Destroy(other.gameObject);
        }
    }
}
