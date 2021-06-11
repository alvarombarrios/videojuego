using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bala : MonoBehaviour
{
   public GameObject bullet;
    public Transform spawnPoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    public AudioSource disparoSound;

    public GameObject gameController;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;
                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                
                shotRateTime = Time.time + shotRate;

                disparoSound.Play ();
                
                Destroy(newBullet, 2);
            }
        }
    }


}
