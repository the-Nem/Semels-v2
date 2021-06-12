using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiStuck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Stucking");
            Destroy(this.gameObject);
        }
    }
}
