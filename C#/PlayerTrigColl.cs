using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigColl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water") { Invoke("StopAll", 0.5f); Debug.Log("Water"); }
    }
    void StopAll() { Player.instance.GameOn = false; }


}
