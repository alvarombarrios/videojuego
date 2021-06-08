using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vistima : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject maleante;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bala")
        {

        Destroy(maleante);


        }
    }
}
